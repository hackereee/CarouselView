using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Demo
{
    class MineDataTemplateSelector : DataTemplateSelector
    {

        public DataTemplate ImageTemplate { get; set; }

        public DataTemplate LabelTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            if (item is MainViewModel.ListImage) {
                return ImageTemplate;
            }
            if(item is MainViewModel.ListLabel)
            {
                return LabelTemplate;
            }

            throw new NotImplementedException();
        }
    }
}
