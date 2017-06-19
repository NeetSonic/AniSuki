using System.Windows.Forms;
using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class ProducerDataGridView : BindingDataGridView<Producer>
    {
        public ProducerDataGridView()
        {
            InitializeComponent();
        }

        protected override bool IsTheSameItem(Producer t1, Producer t2)
        {
            return t1.ID == t2.ID;
        }
    }
}