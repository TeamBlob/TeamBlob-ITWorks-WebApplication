using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Globalization;


namespace ITWorks_Application.Controllers
{
    public class ZoomMeetingDetails
    {
        public String topic { get; set; }
        public String timezone { get; set; }
    }

    public class ZoomController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        
        public IActionResult CreateZoom()
        {
            Task<String> getZoomMeetingTask = getZoomMeeting();
            getZoomMeetingTask.Wait(10000);
            String responsestring = getZoomMeetingTask.Result;

            ChatModel? zmrd = JsonSerializer.Deserialize<ChatModel>(responsestring);

            ViewBag.RAWMessage = responsestring;
            ViewBag.join_url = zmrd.join_url;
            ViewBag.password = zmrd.password;
            ViewBag.topic = zmrd.topic;
            ViewBag.host_email = zmrd.host_email;
            return View();
        }

        public static void CreateZoomStatic(ChatModel model)
        {
            Task<String> getZoomMeetingTask = getZoomMeetingStatic(model);
            getZoomMeetingTask.Wait(10000);
            String responsestring = getZoomMeetingTask.Result;

            ChatModel? zmrd = JsonSerializer.Deserialize<ChatModel>(responsestring);


            model.join_url = zmrd.join_url;
            model.password = zmrd.password;
            model.topic = zmrd.topic;
            model.host_email = zmrd.host_email;
        }
        private static async Task<String> getZoomMeetingStatic(ChatModel model)
        {
            var zmd = new ZoomMeetingDetails();
            zmd.topic = "ITWorks Troubleshooting Schedule at " + model.MeetingSession;
            zmd.timezone = "Asia/Singapore";

            string jsonString = JsonSerializer.Serialize(zmd);

            var httppostrequest = new HttpRequestMessage(HttpMethod.Post, "https://api.zoom.us/v2/users/me/meetings");
            httppostrequest.Headers.TryAddWithoutValidation("Content-Type", "Application/json");
            httppostrequest.Headers.TryAddWithoutValidation("Authorization", "Bearer " + getJWTTokenStatic(model));
            httppostrequest.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await client.SendAsync(httppostrequest);
            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        private static String getJWTTokenStatic(ChatModel model)
        {
            var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("dGotXHhh7tYZ1QHiEnxovQK9Xb0BlUnm8Iev"));

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "xpDLj8crQOWw-g8opGzatw",
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(mySecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
        private async Task<String> getZoomMeeting()
        {
            var zmd = new ZoomMeetingDetails();
            zmd.topic = "ITWorks troubleshooting session at " + DateTime.Now.ToString();
            zmd.timezone = "Asia/Singapore";

            string jsonString = JsonSerializer.Serialize(zmd);

            var httppostrequest = new HttpRequestMessage(HttpMethod.Post, "https://api.zoom.us/v2/users/me/meetings");
            httppostrequest.Headers.TryAddWithoutValidation("Content-Type", "Application/json");
            httppostrequest.Headers.TryAddWithoutValidation("Authorization", "Bearer " + getJWTToken());
            httppostrequest.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await client.SendAsync(httppostrequest);
            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        private String getJWTToken()
        {
            var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("dGotXHhh7tYZ1QHiEnxovQK9Xb0BlUnm8Iev"));

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "xpDLj8crQOWw-g8opGzatw",
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(mySecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
