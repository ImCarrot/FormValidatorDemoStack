using System;
using System.ComponentModel;
using System.Linq;

namespace FormValidatorDemo.ViewModel
{
    internal class QuickAndDirtyViewModel : INotifyPropertyChanged
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(nameof(Name)); }
        }

        private string adminNo;
        public string AdminNo
        {
            get { return adminNo; }
            set { adminNo = value; RaisePropertyChanged(nameof(AdminNo)); }
        }

        private string mobileNo;
        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; RaisePropertyChanged(nameof(MobileNo)); }
        }


        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; RaisePropertyChanged(nameof(Description)); }
        }

        private string lostLocation;
        public string LostLocation
        {
            get { return lostLocation; }
            set { lostLocation = value; RaisePropertyChanged(nameof(LostLocation)); }
        }

        private int itemID;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; RaisePropertyChanged(nameof(ItemID)); }
        }

        private bool isNameError;
        public bool IsNameError
        {
            get { return isNameError; }
            set { isNameError = value; RaisePropertyChanged(nameof(IsNameError)); }
        }

        private bool isMobileNoError;
        public bool IsMobileNoError
        {
            get { return isMobileNoError; }
            set { isMobileNoError = value; RaisePropertyChanged(nameof(IsMobileNoError)); }
        }

        private bool isAdminNoError;
        public bool IsAdminNoError
        {
            get { return isAdminNoError; }
            set { isAdminNoError = value; RaisePropertyChanged(nameof(IsAdminNoError)); }
        }

        private bool isDescriptionError;
        public bool IsDescriptionError
        {
            get { return isDescriptionError; }
            set { isDescriptionError = value; RaisePropertyChanged(nameof(IsDescriptionError)); }
        }

        private bool isLostLocationError;
        public bool IsLostlocationError
        {
            get { return isLostLocationError; }
            set { isLostLocationError = value; RaisePropertyChanged(nameof(IsLostlocationError)); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        internal void ValidateValues()
        {
            IsAdminNoError = IsDescriptionError = IsLostlocationError = IsMobileNoError = IsNameError = IsMobileNoError = false;

            Model.ItemLostFormModel itemLostForm = new Model.ItemLostFormModel();
            var errorList = itemLostForm.GetValidationError(itemID: ItemID, itemDescription: Description, locationLost: LostLocation, personName: Name, contactNo: MobileNo, adminNo: AdminNo, dateLost: new DateTime());
            if (errorList != null)
            {
                foreach (var error in errorList)
                {
                    switch (error.ErrorType)
                    {
                        case Model.ValidationErrors.ID:

                            break;
                        case Model.ValidationErrors.Description:
                            IsDescriptionError = true;
                            break;
                        case Model.ValidationErrors.LocationLost:
                            IsLostlocationError = true;
                            break;
                        case Model.ValidationErrors.PersonName:
                            IsNameError = true;
                            break;
                        case Model.ValidationErrors.ContactNo:
                            IsMobileNoError = true;
                            break;
                        case Model.ValidationErrors.AdminNo:
                            IsAdminNoError = true;
                            break;
                        case Model.ValidationErrors.DateLost:
                            break;
                    }
                }
                return;
            }
            else
            {
                //proceed to what to be done!
            }
        }
    }
}
