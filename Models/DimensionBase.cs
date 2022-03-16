﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rki.CancerDataModel.Models
{

    /// <summary>
    /// Base for Dimension classes.
    /// Naming patterns are disregarded here :o
    /// SQL table data source: 
    /// </summary>
    public abstract class DimensionBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }


        // TODO remove 
        /// <summary>
        /// Fetch and deserialze classes that are given as json.
        /// Follows the convention: 
        /// - class MUST name as file.json
        /// - Folderpath must name as in code
        /// </summary>
        /// <typeparam name="T">class type</typeparam>
        /// <returns>list of all items in json object</returns>
        public static IEnumerable<T> ReadListFromJson<T>() where T : DimensionBase
        {
            // TODO bug pathname
            var list = JsonConvert.DeserializeObject<List<T>>(
                File.ReadAllText(Path.Combine("Models/Dimensions", $"{typeof(T).Name}.json")
                ));
            return list;
        }

        /// <summary>
        /// Auto increments all Id in Model objects. Overwrites.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listWithoutId"></param>
        /// <returns></returns>
        public static IEnumerable<T> AutoIncAllId<T>(IEnumerable<T> listWithoutId) where T : DimensionBase
        {
            int i = 1;
            listWithoutId
                .ToList()
                .ForEach(x =>
                {
                    x.Id = i++;
                });
            return listWithoutId;
        }

    }
}
