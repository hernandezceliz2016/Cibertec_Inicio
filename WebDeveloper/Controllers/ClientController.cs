using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
using WebDeveloper.Resources;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private IDataAccess<Client> _client;
        public ClientController(IDataAccess<Client> client)
        {
            _client = client;
        }
        //private ClientData _client = new ClientData();
        // GET: Client
        public ActionResult Index()
        {
            ViewBag.Title = Resource.Client_Title;
            return View(_client.GetList());
        }
        public ActionResult Create()
        {
            return View(new Client());
        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        //public ActionResult Edit(int id)
        //{
        //    var client = _client.GetClient(id);
        //    if (client == null)
        //        RedirectToAction("Index");
        //    return View(client);
        //}
        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        //public ActionResult Delete(int id)
        //{
        //    var client = _client.GetClient(id);
        //    if (client == null)
        //        RedirectToAction("Index");
        //    return View(client);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Client client)
        {
            if (_client.Delete(client) > 0)
                return RedirectToAction("Index");
            return View();
        }
    }
}