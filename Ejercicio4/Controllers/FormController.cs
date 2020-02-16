using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio4.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Operation model)
        {
            if (model.OperationType == OperationType.Adicion)
            {
                model.Resultado = model.PrimerNumero + model.SegundoNumero;
            }
            else if(model.OperationType == OperationType.Resta)
            {
                model.Resultado = model.PrimerNumero - model.SegundoNumero;
            }
            else if (model.OperationType == OperationType.Division)
            {
                model.Resultado = model.PrimerNumero / model.SegundoNumero;
            }
            else if (model.OperationType == OperationType.Multiplicacion)
            {
                model.Resultado = model.PrimerNumero * model.SegundoNumero;
            }
            else if (model.OperationType == OperationType.Porcentaje)
            {
                model.Resultado = model.PrimerNumero * (model.SegundoNumero / 100);
            }

            return View(model);
        }

    }
}