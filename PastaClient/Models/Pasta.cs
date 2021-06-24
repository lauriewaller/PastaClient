using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PastaClient.Models
{
  public class Pasta
  {
    public int PastaId { get; set; }
    public string Name { get; set; }
    public string NoodleType { get; set; }
    public bool GlutenFree { get; set; }
    public string SauceType { get; set; }
    public string Ingredients { get; set; }
    public string Origin { get; set; }
    public string Url { get; set; }
    public string ImageUrl { get; set; }

    public static List<Pasta> GetPastas()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Pasta> pastaList = JsonConvert.DeserializeObject<List<Pasta>>(jsonResponse.ToString());

      return pastaList;
    }

    public static Pasta GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Pasta pasta = JsonConvert.DeserializeObject<Pasta>(jsonResponse.ToString());

      return pasta;
    }
    public static void Post(Pasta pasta)
    {
      string jsonPasta = JsonConvert.SerializeObject(pasta);
      var apiCallTask = ApiHelper.Post(jsonPasta);
    }
    public static void Put(Pasta pasta)
    {
      string jsonPasta = JsonConvert.SerializeObject(pasta);
      var apiCallTask = ApiHelper.Put(pasta.PastaId, jsonPasta);
    }
    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}