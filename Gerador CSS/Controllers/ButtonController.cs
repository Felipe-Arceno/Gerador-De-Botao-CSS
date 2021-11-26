﻿using Gerador_CSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gerador_CSS.Controllers
{
    public class ButtonController : Controller
    {
        // GET: Button
        public ActionResult GeradorDeBotao(string idButton)
        {
            if (!string.IsNullOrEmpty(idButton))
            {
                try
                {
                    Models.Button button = Class.Button.GetButtonById(idButton);

                    return View(button);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                string button_default_id = Class.Util.GetParam_Button_Default();

                if (!string.IsNullOrEmpty(button_default_id))
                {
                    Models.Button button_padrao = Class.Button.GetButtonById(button_default_id);

                    return View(button_padrao);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }                             
                
            }           
            
        }

        [HttpPost]
        public ActionResult InsertButtonToSuggestionBox(Button button)
        {
            try
            {
                Class.Button.InsertButtonToSuggestionBox(button);                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Index", "Home");
        }
    }
}