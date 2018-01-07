using System;
using System.ComponentModel;

namespace AwesomeMaps
{
    public class DataModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public String Latitude = "";
        public String Longitude = "";

        public DataModel()
        {
        }

        public String lat{
            set {
                Latitude = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this,
						new PropertyChangedEventArgs("lat"));
				}
            }
            get {
                return Latitude;
            }
        }
		public String longt
		{
			set
			{
                Longitude = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this,
						new PropertyChangedEventArgs("longt"));
				}
			}
			get
			{
                return Longitude;
			}
		}
    }
}
