using AsdafObhurRealEstate.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using System.Net;
using System.Net.Mime;

namespace AsdafObhurRealEstate.Helpers
{
    public class WhatsAppsSender
    {
        private readonly HttpClient _http;

        public WhatsAppsSender(HttpClient http)
        {
            _http = http;
        }

        public async Task<bool> SendMessage(string userName, string phoneNumber, string templateName)
        {

            string token = "EAAF9njwav2sBANGBy8C2NjUrziV0eI8qPt8CZAnqZBFUXMta95w09diK5YpY4Fboqv21ZCJm1ccZBdopsiAdvczohX5mRVCdZAq0iRPftyETZAtLDUf4SV9shWDm2ktaDApR462IcV55irLHVmRGl20JcSywznbDM8UYdm3lJ9hxZA2uCYTaZAv6";
            //string token = "dc529569b1e8d06b9736cd90cc00655a";
            string url = @"https://graph.facebook.com/v13.0/102815602578407/messages";

            HttpRequestMessage httpRequestMessage = new();

            httpRequestMessage.Method = new HttpMethod(HttpMethod.Post.ToString());

            httpRequestMessage.RequestUri = new Uri(url);



            Language lang = new Language();
            lang.code = "ar";


            List<Models.Parameter> parameters = new List<Models.Parameter>();

            parameters.Add(new Models.Parameter
            {
                type = "text",
                text = userName
            });

            Component component = new Component()
            {
                type = "header",
                parameters = parameters
            };

            WhatsAppDataModel whatsAppDataModel = new WhatsAppDataModel();
            whatsAppDataModel.messaging_product = "whatsapp";
            whatsAppDataModel.to = phoneNumber;
            whatsAppDataModel.type = "template";
            whatsAppDataModel.template = new Template()
            {
                name = templateName,
                language = lang,
                components = new List<Component>(),

            };
            whatsAppDataModel.template.components.Add(component);


            var serializedObject = JsonConvert.SerializeObject(whatsAppDataModel);

            httpRequestMessage.Content = new StringContent(serializedObject);

            httpRequestMessage.Content.Headers.ContentType
            = new System.Net.Http.Headers.MediaTypeHeaderValue(MediaTypeNames.Application.Json);

            if (!string.IsNullOrEmpty(token))
            {
                httpRequestMessage.Headers.Authorization
               = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }

            var result = await _http.SendAsync(httpRequestMessage);

            var responde = await result.Content.ReadAsStringAsync();


            if (result.StatusCode == HttpStatusCode.InternalServerError ||
                result.StatusCode == HttpStatusCode.BadRequest ||
                result.StatusCode == HttpStatusCode.Unauthorized)
            {
                return false;
              
            }

            return true;

        }
    }
}
