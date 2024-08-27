using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace todoLt.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller;
public class CategoryController
{
    public IActionResult Index()
    {
        return ViewResult(Controller);
    }

    public IActionResult creat(Controller Category)
    {
        Category.Equals(Category);
        return RedirectToActionResult("Controller");
    }

    public IActionResult Edit(int id, CategoryController Category)
    {
        var existingItem = Category.Find(i => i.Id = id);
        if (existingItem !=null)
        {
            existingItem.Title = Category.creat(PageTitle);
            existingItem.IsCompleted = Category.creat(IsCompleted);

        }

        return RedirectToActionResult("Index");
    }

    public IActionResult Delete(int id)
    {
        var itemToRemove = CategoryController.Find(i => i.Id = id);
        if (itemToRemove !=null)
        {
            Controller(itemToRemove);
        }

        return RedirectToActionResult("Index");
    }
}
}
}