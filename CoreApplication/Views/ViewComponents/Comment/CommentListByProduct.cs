using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Views.ViewComponents.Comment
{
    public class CommentListByProduct:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int ID)
        {
            
            var values = commentManager.GetList(ID);
            return View(values);
        }
    }
}
