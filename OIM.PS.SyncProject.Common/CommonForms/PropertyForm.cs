using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIM.PS.SyncProject.Common.CommonForms
{
	public partial class PropertyForm : Form
	{
		GenClassProp _prop = null;

		public PropertyForm()
		{
			InitializeComponent();
		}

		public static GenClassProp AddPProperty(bool canInsert = true, bool canUpdate = true)
		{
			GenClassProp ret = null;
			PropertyForm frm = new PropertyForm();
			frm.chkInsert.Enabled = canInsert;
			frm.chkUpdate.Enabled = canUpdate;
			if (!canInsert) frm.chkInsert.Checked = false;
			if (!canUpdate) frm.chkUpdate.Checked = false;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				ret = frm._prop;
			}

			return ret;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPropertyName.Text))
			{
				MessageBox.Show("Property Name is a mandatory field");
				return;
			}

			if (chkCombinedPrimary.Checked && cmbDataType.Text != "String")
			{
				MessageBox.Show("Data type for combined primary key must be 'String'");
				return;
			}

			_prop = new GenClassProp()
			{
				DataType = (DataTypes)System.Enum.Parse(typeof(DataTypes), cmbDataType.Text),
				PropertyName = txtPropertyName.Text,
				IsPrimaryKey = chkIsPrimaryKey.Checked,
				IsAutoFill = chkIsAutoFill.Checked,
				IsDisplay = chkIsDisplay.Checked,
				IsMandatory = chkIsMandatory.Checked,
				IsUniqueKey = chkIsUniqueKey.Checked,
				IsMultivalue = chkIsMultiValue.Checked,
				IsRevision = chkIsRevision.Checked,
				IsCombinedPrimaryKey = chkCombinedPrimary.Checked,
				IncludeInCombinedPrimaryKey = chkIncludeInPrimary.Checked,
				BindGetAll = chkGetAll.Checked,
				BindGet = chkGet.Checked,
				BindUpdate = chkUpdate.Checked,
				BindInsert = chkInsert.Checked
			};

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void PropertyForm_Load(object sender, EventArgs e)
		{
			cmbDataType.Text = "String";
			chkGet.Checked = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void lblManyToMany_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("For Many-To-Many object, if it contains only foreign keys ");
			sb.AppendLine("    (No unique primary key, e.g. UserID and GroupID): ");
			sb.AppendLine("Create a virtual primary key (check 'Combined (virtual) primary key')");
			sb.AppendLine("    which will combine foreign keys in a vertical bar '|' separated string.");
			sb.AppendLine("Mark each foreign key as 'Field to include in combined primary key'.");
			sb.AppendLine("If unique primary key exists in target system record - just check 'IsPrimaryKey' checkbox.");

			MessageBox.Show(sb.ToString(), "Many-to-Many record configuration");
		}

		private void chkCombinedPrimary_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCombinedPrimary.Checked)
			{
				chkIncludeInPrimary.Checked = false;
				chkIsPrimaryKey.Checked = false;

				chkIsMandatory.Checked = true;
				chkIsUniqueKey.Checked = true;

				if (cmbDataType.Text != "String")
				{
					MessageBox.Show("Data type for combined primary key must be 'String'");
					cmbDataType.Text = "String";
				}
			}
		}

		private void chkIncludeInPrimary_CheckedChanged(object sender, EventArgs e)
		{
			if (chkIncludeInPrimary.Checked)
			{
				chkIsPrimaryKey.Checked = false;
				chkCombinedPrimary.Checked = false;

				chkIsMandatory.Checked = true;
			}
		}

		private void chkIsPrimaryKey_CheckedChanged(object sender, EventArgs e)
		{
			if (chkIsPrimaryKey.Checked)
			{
				chkCombinedPrimary.Checked = false;
				chkIncludeInPrimary.Checked = false;
				chkGetAll.Checked = true;
			}
		}

		private void cmbDataType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbDataType.Text != "String")
			{
				if (chkCombinedPrimary.Checked)
				{
					MessageBox.Show("Data type for combined primary key must be 'String'");
					cmbDataType.Text = "String";
				}
			}
		}
	}
}
