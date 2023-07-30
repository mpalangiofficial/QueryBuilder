using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public partial class SelectSortFieldForm : Form
    {
        private List<NameAlias> _usedTables;
        private List<NameAlias> _selectedFields = new List<NameAlias>();
        private List<FunctionField> _selectedFunctionFields = new List<FunctionField>();
        public List<DbTableModel> DbTables { set; get; }

        public List<NameAlias> SelectedFields
        {
            get => _selectedFields;
            set
            {
                if (value is null)
                    _selectedFields = new List<NameAlias>();
                else
                    _selectedFields = value;

                //refresh();
            }
        }

        public List<FunctionField> SelectedFunctionFields
        {
            get => _selectedFunctionFields;
            set
            {
                if (value is null)
                    _selectedFunctionFields = new List<FunctionField>();
                else
                    _selectedFunctionFields = value;
                //refresh();
            }

        }

        public List<NameAlias> UsedTables
        {
            set
            {
                _usedTables = value;
               
            }
            get => _usedTables;
        }

        public SelectSortFieldForm()
        {
            InitializeComponent();
        }
    }
}
