﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiProxy.TestServer.Models;

namespace WebApiProxy.TestServer.Controllers
{
    /// <summary>
    /// Values service
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Retrieve many values
        /// </summary>
        public IEnumerable<ItemTestViewModel> Get()
        {
            yield return new ItemTestViewModel { Name = "One", Value = ItemTestEnum.One };
            yield return new ItemTestViewModel { Name = "Two", Value = ItemTestEnum.Two };
            yield return new ItemTestViewModel { Name = "Three", Value = ItemTestEnum.Three };
        }

        /// <summary>
        /// Get specific <value>Value</value>
        /// </summary>
        /// <param name="id">id of the value</param>
        public ItemTestViewModel Get(ItemTestEnum id)
        {
            return Get().FirstOrDefault(i => i.Value == id);
        }

        /// <summary>
        /// Find by name
        /// </summary>
        /// <param name="name">Name of thing to find</param>
        [HttpGet]
        public ItemTestViewModel FindByName(string name)
        {
            return Get().FirstOrDefault(i => i.Name == name);
        }

        /// <summary>
        /// Push new value
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]ItemTestViewModel value)
        {
        }
    }
}
