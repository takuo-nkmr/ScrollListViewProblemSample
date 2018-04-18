using Xamarin.Forms;

namespace ScrollListViewProblemSample
{
    public partial class ScrollListViewProblemSample : MasterDetailPage
    {
        public ScrollListViewProblemSample()
        {
            InitializeComponent();

            // 横向き時にマスターページを非表示
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}
