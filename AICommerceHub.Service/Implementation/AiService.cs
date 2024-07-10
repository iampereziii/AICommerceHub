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


        public void testCompletion()
        {


            OpenAIClientOptions clientOptions = new OpenAIClientOptions() { OrganizationId = "org-vUV9ltygQxgun9tfnDh5rjMO" };

            ChatClient client = new(model: "gpt-4o", credential: Environment.GetEnvironmentVariable("OPENAI_API_KEY"), clientOptions);

            ChatCompletion completion = client.CompleteChat("Say random word");

            Console.WriteLine($"[ASSISTANT]: {completion}");
        }

        public String GenerateHTML()
        {
            testCompletion();
            string htmlString = @"
                <div class='container mt-5'>
                    <h1 class='text-center mb-4'>Place Your Order</h1>
                    <form>
                        <div class='form-group'>
                            <label for='name'>Name</label>
                            <input type='text' class='form-control' id='name' placeholder='Enter your name' required>
                        </div>
                        <div class='form-group'>
                            <label for='email'>Email address</label>
                            <input type='email' class='form-control' id='email' placeholder='Enter your email' required>
                        </div>
                        <div class='form-group'>
                            <label for='address'>Address</label>
                            <textarea class='form-control' id='address' rows='3' placeholder='Enter your address' required></textarea>
                        </div>
                        <div class='form-group'>
                            <label for='product'>Product</label>
                            <select class='form-control' id='product' required>
                                <option value='' disabled selected>Select a product</option>
                                <option value='product1'>Product 1</option>
                                <option value='product2'>Product 2</option>
                                <option value='product3'>Product 3</option>
                            </select>
                        </div>
                        <div class='form-group'>
                            <label for='quantity'>Quantity</label>
                            <input type='number' class='form-control' id='quantity' placeholder='Enter quantity' required>
                        </div>
                        <button type='submit' class='btn btn-primary'>Submit Order</button>
                    </form>
                </div>";

            return htmlString;


        }
    }
}
