using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace CheckList.Controllers
//{
//    public class AddController : Controller
//    {
//        public void AddItem()
//        {
//            // Get the input
//            const taskText = document.getElementById('checklistInput').value;

//            // Make sure the input is not empty
//            if (taskText.trim() !== '')
//            {
//                // Create a new check list item
//                const li = document.createElement('li');
//                li.textContent = taskText;

//                // Add the task to the checklist
//                document.getElementById('checklist').appendChild(li);

//                // Warning for the text box
//                document.getElementById('checklistInput').value = '';
//            }
//            else
//            {
//                alert('Please enter a task!');
//            }
//        }
//    }
//}
