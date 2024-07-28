using My_college_project.Models.Entities;
using My_college_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_college_project.Forms.Components
{
    static internal class GetCorsePanel
    {
        static public Panel LoadCourseListItem(Course course, Point point, EventHandler? onClick)
        {
            Panel panel_courseItem = new Panel
            {
                AutoScroll = true,
                BorderStyle = BorderStyle.Fixed3D,
                Name = "item",
                Size = new Size(300, 200),
                Location = point,
                TabIndex = 17,
                Visible = true,
                RightToLeft = RightToLeft.Yes
            };
            Label lCourseName = new Label
            {
                Location = new Point(100, 10),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Text = course.Name
            };
            Label lPrice = new Label
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Text = $"מחיר: {course.Price}",
                Location = new Point(180, 50)
            };
            Label lSubjectsTitle = new Label
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Text = "נושאים",
                Location = new Point(180, 70)
            };
            Label labelBtn_pay = new Label
            {
                AutoSize = true,
                BackColor = Color.RoyalBlue,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.White,
                Location = new Point(50, 50),
                Name = "labelBtn_update",
                Size = new Size(80, 20),
                TabIndex = 10,
                Text = "תשלום",
                TextAlign = ContentAlignment.MiddleCenter,
                Tag = course,
            };
            labelBtn_pay.Click += onClick;
            int height = 100;
            panel_courseItem.Controls.AddRange([lCourseName, lPrice, lSubjectsTitle, labelBtn_pay]);
            foreach (var s in course.Subjects)
            {
                panel_courseItem.Controls.Add(
                    new()
                    {
                        Location = new Point(180, height),
                        Text = s.Name
                    });
                height += 20;
            }
            return panel_courseItem;
        }
    }
}
