using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncemenetDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncemenetController : Controller
    {
        private readonly IAnnouncemenetService _announcemenetService;
        private readonly IMapper _mapper;
        public AnnouncemenetController(IAnnouncemenetService announcemenetService, IMapper mapper)
        {
            _announcemenetService = announcemenetService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncemenetListDTO>>(_announcemenetService.TGetList());
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncemenet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncemenet(AnnouncemenetAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcemenetService.TAdd(new Announcemenet()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult DeleteAnnouncemenet(int id)
        {
            var values = _announcemenetService.TGetById(id);
            _announcemenetService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnouncemenet(int id)
        {
            var values = _mapper.Map<AnnouncemenetUpdateDto>(_announcemenetService.TGetById(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncemenet(AnnouncemenetUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _announcemenetService.TUpdate(new Announcemenet
                {
                    AnnouncemenetID = model.AnnouncemenetID,
                    Title = model.Title,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
