using System.Linq;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Templete;

namespace AniSuki.View
{
    public partial class FrmManageProducer : FrmBase
    {
        public FrmManageProducer()
        {
            InitializeComponent();
        }

        private void FrmManageProducer_Load(object sender, System.EventArgs e)
        {
            producerDataGridView1.DataList = new ProducerList(DataAccess.GetProducer().ToList());
        }
    }
}