using Data.Context;
using FirstApp.Dto;
using System.Linq;
using System.Web.Mvc;
using Data.Common;
using Data.Models;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace FirstApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public TodoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }

        // GET: Todo
        public ActionResult Index()
        {
            var toDo = _uow.Repository<ToDo>().GetList();
            var toDoDto = _mapper.Map<IEnumerable<ToDoDto>>(toDo);
            return View(toDoDto);
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Data.Models.ToDo ToDo)
        {
            _uow.Repository<ToDo>().Add(ToDo);



            //objDataContext.Todos.Add(objToDo);
            //objDataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        // POST: Todo/Create


        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Todo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
