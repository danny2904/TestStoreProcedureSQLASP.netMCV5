using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestStoreProcedure.Models;

public class HomeController : Controller
{
    private QLCCHCEntities db = new QLCCHCEntities(); // Tên của bạn ADO.NET Entity Data Model

    public ActionResult Index()
    {
        List<TTHCModel> tthcs = db.sp_GetAllTTHC().Select(t => new TTHCModel
        {
            MaTTHC = t.IdTTHC,
            TenTTHC = t.NameTTHC,
            CQTThucHien = t.CQTThucHien,
            VanBanQuyDinh = t.VanBanQuyDinh,
            QuyetDinhCongBo = t.QuyetDinhCongBo,
            MucDoDVCTT = t.MucDoDVCTT,
            TichHopCongDVCQG = t.TichHopCongDVCQG
        }).ToList();

        return View(tthcs);
    }
}
