using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Picker = Xamarin.Forms.Picker;
using Entry = Xamarin.Forms.Entry;

namespace nataljaelemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class maakonnad : ContentPage
    {
        Picker pick;
        Editor editor;
        Entry entry;
        public maakonnad()
        {

            Image image;
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                  new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                  new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                  new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},

                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            pick = new Xamarin.Forms.Picker
            {
                Title = "уезды"
            };

            pick.Items.Add("ИДА-ВИРУМАА");
            pick.Items.Add("ЙЫГЕВАМАА");
            pick.Items.Add("ЛЯЭНЕМАА");
            pick.Items.Add("ЛЯЭНЕ-ВИРУМАА");
            pick.Items.Add("ПЫЛВАМАА");
            pick.Items.Add("ПЯРНУМАА");
            pick.Items.Add("РАПЛАМАА");
            pick.Items.Add("СААРЕМАА");
            pick.Items.Add("ТАРТУМАА");
            pick.Items.Add("ХАРЬЮМАА");
            pick.Items.Add("ХИЙУМАА");
            pick.Items.Add("ЯРВАМАА");
            pick.Items.Add("ВЫРУМАА");
            pick.Items.Add("ВИЛЬЯНДИМАА");
            pick.Items.Add("ВАЛГАМАА");
            gr.Children.Add(pick, 0, 0);
            pick.SelectedIndexChanged += Pick_SelectedIndexChanged;

            image = new Image();
            Image source = "pilt.png";



            entry = new Entry { Text = "уезды" };

            editor = new Editor { Placeholder = "уезды" };

            gr.Children.Add(editor, 1, 0);

            private void Pick_SelectedIndexChanged(object sender, EventArgs e)
            {
                editor.Text = "уезды" + pick.Items[pick.SelectedIndex];
            }


            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                }
            };

            pick = new Xamarin.Forms.Picker
            {
                Title = "уезды"
            };

            pick.Items.Add("Ида-Вирумаа считается одним из крупнейших уездов Эстонии. Располагается он на северо-востоке республики и населён, преимущественно, этническими русскими.");
            pick.Items.Add("Эстонский уезд со сложнопроизносимым названием Йыгевамаа расположен в восточной части республики. В его состав входят тринадцать самоуправлений, в числе которых три города и десять волостей.");
            pick.Items.Add("Эстонский уезд Ляэнемаа является крайней западной материковой частью республики. С запада и севера эта территория омывается Балтийским морем");
            pick.Items.Add("Эстонский уезд Ляэне-Вирумаа располагается в северо-восточной части Эстонии. Его северная часть омывается водами Финского залива. ");
            pick.Items.Add("Название эстонского уезда Пылвамаа можно встретить и в несколько ином написании. Некоторое время назад «эль» в этом топониме считалась мягкой, что в русскоязычном написании подчёркивалось мягким знаком.");
            pick.Items.Add("Эстонский уезд Пярнумаа занимает самую большую площадь в республике. Однако по количеству проживающего здесь населения он значительно уступает, например, Харьюмаа. ");
            pick.Items.Add("Уезд Рапламаа располагается в западной части Эстонии. На востоке он граничит с уездом Ярвамаа, на юге – с Пярнумаа, на западе – с Ляэнемаа, на севере – с Харьюмаа.");
            pick.Items.Add("Территория уезда Сааремаа состоит из нескольких островов разного размера. Крупнейшим из них является остров Сааремаа, во времена Российской Империи именовавшийся Эзелем. ");
            pick.Items.Add("Уезд Тартумаа, или, как правильнее сказать по-русски – Тартуский уезд, располагается в центральной части Эстонии.");
            pick.Items.Add("Уезд Харьюмаа является крупнейшим по численности населения из пятнадцати, имеющихся на территории Эстонии.");
            pick.Items.Add("Эстонский уезд Хийумаа располагается на территории одноимённого острова. Также к нему относятся окрестные небольшие острова. ");
            pick.Items.Add("Эстонский уезд Ярвамаа расположен в центральной части республики.");
            pick.Items.Add("Уезд Вырумаа расположен в юго-восточной части Эстонии. Относящаяся к нему территория граничит с Россией и Латвией.");
            pick.Items.Add("Эстонский уезд Вильяндимаа расположен в южной части республики. Во времена средневековья этот район был довольно важным политическим и торговым центром Прибалтики.");
            pick.Items.Add("Уезд Валгамаа расположен в южной части Эстонии. Этот регион граничит с Латвийской республикой.");
            gr.Children.Add(pick, 0, 0);
            pick.SelectedIndexChanged += Pick_SelectedIndexChanged;

            image = new Image();
           

            entry = new Entry { Text = "уезды" };

            editor = new Editor { Placeholder = "уезды" };

            gr.Children.Add(editor, 1, 0);

            private void Pick_SelectedIndexChanged(object sender, EventArgs e)
            {
                editor.Text = "уезды" + pick.Items[pick.SelectedIndex];
            }
        }
    }
}