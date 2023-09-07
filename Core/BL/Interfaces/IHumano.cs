using Models.API.Request;
using Models.API.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.BL.Interfaces
{
    public interface IHumano
    {
        //Task<List<HumanoResponseViewModel>> SELECTHumanoGeneral(HumanoRequestViewModel x);
        Task<List<HumanoResponseViewModel>> SELECTHumanoGeneral(int _intAccion, int _intHumanoKey);
        Task<CRUDHumanoResponsetViewModel> CRUDHumanoGeneral(CRUDHumanoRequestViewModel x);
        Task<CRUDHumanoResponsetViewModel> UPDATEHumanoGeneral(int _intAccion, int _intHumanoKey, CRUDHumanoRequestViewModel X);
    }
}
