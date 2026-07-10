using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SfRotatorDynamicTemplate
{
    public class RotatorViewModel
    {

        public ObservableCollection<RotatorModel> ImageCollection { get; set; }

        public RotatorViewModel()
        {
            ImageCollection = new ObservableCollection<RotatorModel>()
            {
                new RotatorModel("image1.png"),
                new RotatorModel("animal5.png"),
                new RotatorModel("animal3.png")
            };
        }

    }

    public class RotatorTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }

        public DataTemplate SpecialTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var model = item as RotatorModel;

            if (model?.Image == "image1.png")
            {
                return SpecialTemplate;
            }

            return DefaultTemplate;
        }
    }
}
