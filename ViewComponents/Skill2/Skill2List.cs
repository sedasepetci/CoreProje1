using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje1.ViewComponents.Skill2
{
    public class Skill2List:ViewComponent
    {
        Skill2Manager skill2Manager = new Skill2Manager(new EfSkill2Dal());
        public IViewComponentResult Invoke()
        {
            var values = skill2Manager.TGetList();
            return View(values);
        }
       

    }
}
