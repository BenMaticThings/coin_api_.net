using Newtonsoft.Json;

namespace coinbaseapi.Models
{
  public class CurrentPriceResponse
  {
    public CurrentPriceResponseTime Time { get; set; }
    public CurrentPriceResponseBPI BPI { get; set; }

    public CurrentPriceResponseData data { get; set; }

    


    }

  public class CurrentPriceResponseTime
  {
    public string Updated { get; set; }
    public string UpdatedIso { get; set; }
    public string UpdatedUk { get; set; }
  }

  public class CurentPriceResponseIndex
  {
    public string Code { get; set; }
    public string Rate { get; set; }
    public string Description { get; set; }

    [JsonProperty("rate_float")]
    public float RateFloat { get; set; }

    public float NZD { get; set; }

    public float ETH { get; set; }



    }

  public class CurrentPriceResponseBPI
  {
    public CurentPriceResponseIndex USD { get; set; }
    public CurentPriceResponseIndex NZD { get; set; }


  }


public class CurrentPriceResponseData
    {


        public CurentPriceResponseIndex rates { get; set; } 

    
        //public CurentPriceResponseIndex ETH { get; set; }


    }
}