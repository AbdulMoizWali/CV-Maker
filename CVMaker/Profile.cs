using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL;

namespace CVMaker
{
	public class Profile
	{
		private String profileID;
		private String first_name;
		private String last_name;
		private String gender;
		private String country;
		private String city;
		private String phone;
		private Image profilePic;
		private List<Social> socials = new List<Social>();
		private List<Skill> skills = new List<Skill>();
		private List<Experience_Class> experiences = new List<Experience_Class>();
		private List<Education> educations = new List<Education>();

		public string ProfileID { get => profileID; private set => profileID = value; }
		public string First_name { get => first_name; private set => first_name = value; }
		public string Last_name { get => last_name; private set => last_name = value; }
		public string Gender { get => gender; private set => gender = value; }
		public string Country { get => country; private set => country = value; }
		public string City { get => city; private set => city = value; }
		public string Phone { get => phone; private set => phone = value; }
		public Image ProfilePic { get => profilePic; private set => profilePic = value; }
		public List<Social> Socials { get => socials; private set => socials = value; }
		public List<Skill> Skills { get => skills; private set => skills = value; }
		public List<Experience_Class> Experiences { get => experiences; private set => experiences = value; }
		public List<Education> Educations { get => educations; private set => educations = value; }



		public Profile()
		{
			SQLConnect.GetDataTableFromTable(
				SQLConnect.ProcedureQuery("Get_ActiveUserProfile"),
				(dataTable) =>
				{
					ProfileID = dataTable.Rows[0]["ProfileID"].ToString();
					First_name = dataTable.Rows[0]["First_name"].ToString();
					Last_name = dataTable.Rows[0]["Last_name"].ToString();
					Gender = dataTable.Rows[0]["Gender"].ToString();
					Country = dataTable.Rows[0]["Country"].ToString();
					City = dataTable.Rows[0]["City"].ToString();
					Phone = dataTable.Rows[0]["Phone"].ToString();
					ProfilePic = ConvertByteToImage( (byte[]) dataTable.Rows[0]["ProfilePic"]);
				}
			);

			SQLConnect.GetDataTableFromTable(
				SQLConnect.ProcedureQuery("Get_ActiveUserProfile_Social"),
				(dataTable) =>
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						Socials.Add(new Social(dataTable.Rows[i]["Title"].ToString(), dataTable.Rows[i]["Link"].ToString()));
					}
				}
			);
			string Level = "";
			SQLConnect.GetDataTableFromTable(
				SQLConnect.ProcedureQuery("Get_ActiveUserProfile_Skills"),
				(dataTable) =>
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						if (dataTable.Rows[i]["Level"].ToString() == "1")
						{
							Level = "Beginner";
						}
						else if (dataTable.Rows[i]["Level"].ToString() == "2")
						{
							Level = "Intermediate";
						}
						else if (dataTable.Rows[i]["Level"].ToString() == "3")
						{
							Level = "Expert";
						}
						Skills.Add(new Skill(dataTable.Rows[i]["Title"].ToString(), Level));
					}
				}
			);

			SQLConnect.GetDataTableFromTable(
				SQLConnect.ProcedureQuery("Get_ActiveUserProfile_Experience"),
				(dataTable) =>
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						Experiences.Add(
							new Experience_Class(
								dataTable.Rows[i]["Title"].ToString(), 
								dataTable.Rows[i]["Company_name"].ToString(),
								dataTable.Rows[i]["Description"].ToString(),
								dataTable.Rows[i]["Starting_Date"].ToString(),
								dataTable.Rows[i]["Ending_Date"].ToString(),
								dataTable.Rows[i]["Job_type"].ToString()
						));
					}
				}
			);


			SQLConnect.GetDataTableFromTable(
				SQLConnect.ProcedureQuery("Get_ActiveUserProfile_Education"),
				(dataTable) =>
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						Educations.Add(
							new Education(
								dataTable.Rows[i]["Title"].ToString(),
								dataTable.Rows[i]["Institute"].ToString(),
								dataTable.Rows[i]["City"].ToString(),
								dataTable.Rows[i]["Country"].ToString(),
								dataTable.Rows[i]["Starting_Date"].ToString(),
								dataTable.Rows[i]["Ending_Date"].ToString()
						));
					}
				}
			);
		}

		private Image ConvertByteToImage(byte[] img)
		{
			MemoryStream ms = new MemoryStream(img);
			return Image.FromStream(ms);
		}

	}

	public class Social
	{
		//private int SocialID;
		private String title;
		private String link;

		public string Title { get => title; private set => title = value; }
		public string Link { get => link; private set => link = value; }

		public Social(string title, string link)
		{
			Title = title;
			Link = link;
		}
	}

	public class Skill
	{
		//private int SkillID;
		public String Title;
		public String Level;

		public Skill(string title, string level)
		{
			Title = title;
			Level = level;
		}
	}

	public class Experience_Class
	{
		//private int ExperienceID;
		private String title;
		private String companyName;
		private String description;
		private String startingDate;
		private String endingDate;
		private String job_type;

		public string Title { get => title; private set => title = value; }
		public string CompanyName { get => companyName; private set => companyName = value; }
		public string Description { get => description; private set => description = value; }
		public string StartingDate { get => startingDate; private set => startingDate = value; }
		public string EndingDate { get => endingDate; private set => endingDate = value; }
		public string Job_type { get => job_type; private set => job_type = value; }

		public Experience_Class(string title, string companyName, string description, string startingDate, string endingDate, string job_type)
		{
			Title = title;
			CompanyName = companyName;
			Description = description;
			StartingDate = startingDate;
			EndingDate = endingDate;
			Job_type = job_type;
		}
	}

	public class Education
	{
		//private int EducationID;
		private String title;
		private String institute;
		private String city;
		private String country;
		private String startingDate;
		private String endingDate;

		public string Title { get => title; private set => title = value; }
		public string Institute { get => institute; private set => institute = value; }
		public string City { get => city; private set => city = value; }
		public string Country { get => country; private set => country = value; }
		public string StartingDate { get => startingDate; private set => startingDate = value; }
		public string EndingDate { get => endingDate; private set => endingDate = value; }

		public Education(string title, string institute, string city, string country, string startingDate, string endingDate)
		{
			Title = title;
			Institute = institute;
			City = city;
			Country = country;
			StartingDate = startingDate;
			EndingDate = endingDate;
		}
	}

}
