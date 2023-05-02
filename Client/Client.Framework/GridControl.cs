using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Framework
{
   public class GridControl<TModel>
    {
        DataGridView grid;
        BindingSource bindingSource;
        public GridControl(Control container)
        {
            grid = new DataGridView();
            container.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;
            grid.AutoGenerateColumns = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public GridControl<TModel>  AddTextBoxColum<TProperty>(Expression<Func<TModel,TProperty>> selector,string title )
        {
            var propertyName = new ExpressionHandler().GetPropertyName(selector);
            grid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = title,
                DataPropertyName = propertyName
            });
                
            return this;
        }
        public GridControl<TModel> SetDataSource(IEnumerable<TModel> dataSource)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            grid.DataSource = bindingSource;
            bindingSource.ResetBindings(true);
            return this;
        }
        public void RsetBinding()
        {
            bindingSource?.ResetBindings(true);
        }
        public TModel CurrentItem
        {
            get
            {
                return (TModel)bindingSource?.Current;
            }
        }
    }
}
