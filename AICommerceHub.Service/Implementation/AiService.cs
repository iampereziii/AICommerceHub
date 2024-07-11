using OpenAI;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Service.Implementation
{
    public class AiService
    {


        public String testCompletion()
        {
            string jsonBody = @"
                    {
                      ""id"": 1,
                      ""name"": ""Sample Product"",
                      ""description"": ""This is a sample product description."",
                      ""stock"": 50,
                      ""price"": 29.99,
                      ""category"": ""Electronics"",
                      ""imageUrl"": ""https://example.com/sample-product.jpg""
                    }";


            OpenAIClientOptions clientOptions = new OpenAIClientOptions() { OrganizationId = "org-vUV9ltygQxgun9tfnDh5rjMO" };

            ChatClient client = new(model: "gpt-4o", credential: Environment.GetEnvironmentVariable("OPENAI_API_KEY"), clientOptions);



            List<ChatMessage> chatMessages = new List<ChatMessage>();

            SystemChatMessage systemChatMessage = new SystemChatMessage("You are a Senior Front-end developer.");
            SystemChatMessage techPrommpt = new SystemChatMessage("Consider this schema: " + jsonBody);
            SystemChatMessage form = new SystemChatMessage("POST should be /api/product/");
            UserChatMessage userChatMessage = new UserChatMessage("Create an html about add product with pure bootstrap only without any custom styling. Don't include any explanations in your responses.");


            UserChatMessage prompt = new UserChatMessage("Theme should be aesthetic.");


            chatMessages.Add(systemChatMessage);
            chatMessages.Add(techPrommpt);
            chatMessages.Add(form);
            chatMessages.Add(userChatMessage);
            chatMessages.Add(prompt);


            ChatCompletion completion = client.CompleteChat(chatMessages);
            Console.WriteLine($"[ASSISTANT]: {completion}");
            return completion.Content.First().ToString().Replace("```html", "").Replace("```", "");
        }

        public String GenerateHTML()
        {
            return testCompletion();
            //string htmlString = @"
            //    <div class='container mt-5'>
            //        <h1 class='text-center mb-4'>Place Your Order</h1>
            //        <form>
            //            <div class='form-group'>
            //                <label for='name'>Name</label>
            //                <input type='text' class='form-control' id='name' placeholder='Enter your name' required>
            //            </div>
            //            <div class='form-group'>
            //                <label for='email'>Email address</label>
            //                <input type='email' class='form-control' id='email' placeholder='Enter your email' required>
            //            </div>
            //            <div class='form-group'>
            //                <label for='address'>Address</label>
            //                <textarea class='form-control' id='address' rows='3' placeholder='Enter your address' required></textarea>
            //            </div>
            //            <div class='form-group'>
            //                <label for='product'>Product</label>
            //                <select class='form-control' id='product' required>
            //                    <option value='' disabled selected>Select a product</option>
            //                    <option value='product1'>Product 1</option>
            //                    <option value='product2'>Product 2</option>
            //                    <option value='product3'>Product 3</option>
            //                </select>
            //            </div>
            //            <div class='form-group'>
            //                <label for='quantity'>Quantity</label>
            //                <input type='number' class='form-control' id='quantity' placeholder='Enter quantity' required>
            //            </div>
            //            <button type='submit' class='btn btn-primary'>Submit Order</button>
            //        </form>
            //    </div>";

            //return htmlString;


        }
    }
}
