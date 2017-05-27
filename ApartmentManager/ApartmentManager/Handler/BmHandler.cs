﻿using System;
using System.Collections.ObjectModel;
using Windows.UI.Popups;
using ApartmentManager.Model;
using ApartmentManager.Persistency;
using ApartmentManager.ViewModel;
using Newtonsoft.Json;
using ApartmentManager.Singletons;

namespace ApartmentManager.Handler
{
   public class BmHandler
    {
        private BmViewModel _vm;

        public BmHandler(BmViewModel vm)
        {
            _vm = vm;
        }

        public void GetApartments()
        {
            BmSingleton.Instance.Apartments = JsonConvert.DeserializeObject<ObservableCollection<Apartment>> (ApiClient.GetData("api/Apartments/"));
        }

        public void CreateApartment()
        {
            try
            {
                ApiClient.PostData("api/Apartments/", _vm.ApartmentTemplate);
                GetApartments();
                _vm.ApartmentTemplate = new Apartment();
            }
            catch (Exception e)
            {
                var msg = new MessageDialog(e.Message).ShowAsync();
            }
        }
        public void UpdateApartment()
        {
            try
            {
                ApiClient.PutData("api/Apartments/" + _vm.ApartmentTemplate.ApartmentId, _vm.ApartmentTemplate);
                GetApartments();
            }
            catch (Exception e)
            {
                var msg = new MessageDialog(e.Message).ShowAsync();
            }
        }
        public void DeleteApartment()
        {
            try
            {
                ApiClient.DeleteData("api/Apartments/" + _vm.ApartmentTemplate.ApartmentId);
                BmSingleton.Instance.Apartments.Remove(_vm.ApartmentTemplate);
                GetApartments();
            }
            catch (Exception e)
            {
                var msg = new MessageDialog(e.Message).ShowAsync();
            }
        }

        public async void UploadApartmentPlan()
        {
            _vm.ApartmentTemplate.PlanPicture = await ImgurPhotoUploader.UploadPhotoAsync();
        }

        public void ClearApartmentTemplate()
        {
            _vm.ApartmentTemplate = new Apartment();
        }
    }
}
