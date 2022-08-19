using AsdafObhurRealEstate.Models;
using RestSharp;
using System.Diagnostics;

namespace AsdafObhurRealEstate.Helpers
{
    public static class WhatsAppsSender
    {

        public static async Task<bool> SendMessage(string userName, string phoneNumber)
        {
            string token = "EAAGTDYyBDuQBAIveNqMbVIrXDdFMZAhKJkCtWNZBdw7J9ud8lUDgo9bkFYVLbRKMeTfV0Nk1rfq2AzLDOqN753WAAhEDosIJwox8LWJkKQHThXY1ssdgPz0RP79tLVemleF3gwLwdN4QGz35r4hGLOZAp8hXXYL98C8Awe3LUMtPgIGaftc9no71npaT2by9oyas7XNoAZDZD";

            string url = @"https://graph.facebook.com/v13.0/110113335146757/messages";
            Uri baseUrl = new Uri(url);

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest("messages",Method.Post);


            request.AddHeader("Authorization", "Bearer"+ token);

            request.AddHeader("Content-Type", "application/json");

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
            whatsAppDataModel.messageing_product = "whatsapp";
            whatsAppDataModel.to = phoneNumber;
            whatsAppDataModel.type = "template";
            whatsAppDataModel.template = new Template()
            {
                name = "send_open",
                language = lang,
                components = new List<Component>(),

            };
            whatsAppDataModel.template.components.Add(component);
            
            request.AddBody(whatsAppDataModel);

            try
            {
                var response = await client.PostAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }

            return false;

        }
    }
}
