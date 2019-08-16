using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Repositiry
{
	public class BlogContext : DbContext
	{
		static BlogContext()
		{
			Database.SetInitializer(new BlogContexttInitializer());
		}
		public BlogContext(string nameOrConnectionString): base(nameOrConnectionString){ }
		//Set Guests
		public IDbSet<Guest> Guests { get; set; }
		//Set Profiles
		public IDbSet<Profile> Profiles { get; set; }
		//Set News
		public IDbSet<News> Newses { get; set; }

		//Method for add guest
		public void AddGuest(string name, string text)
		{
			Guests.Add(
				new Guest
				{
					Name = name,
					GuestText= text,
					Date = DateTime.Now
				});
			SaveChanges();
		}
		//Method for add profile
		public void AddProfile(string firstName, string lastName, string sex,string kross,string treck, string street, string chopper, string enduro, string turing)
		{
			Profiles.Add(
			new Profile
			{
				FirstName = firstName,
				SecondName = lastName,
				Kross = kross,
				Treck=treck,
				Street=street,
				Chopper=chopper,
				Enduro=enduro,
				Turing=turing
			});
			SaveChanges();
		}
	}
	public class BlogContexttInitializer : CreateDatabaseIfNotExists<BlogContext>
	{

		protected override void Seed(BlogContext context)
		{
			var guests = new List<Guest>
				{
				new Guest {
				Name = "Иван",
				Date = DateTime.Parse("2011-07-01"),
				GuestText = "Всё отлично!"
				},
				new Guest {
				Name = "Иван",
				Date = DateTime.Parse("2011-07-01"),
				GuestText = "Всё отлично!" },
				new Guest {
				Name = "Иван",
				Date = DateTime.Parse("2011-07-01"),
				GuestText = "Всё отлично!"
				},
		};
			guests.ForEach(std => context.Guests.Add(std));
			context.SaveChanges();

			var profiles = new List<Profile>
				{
				new Profile {
					FirstName = "Иван",
					SecondName = "Иванов",
					Sex="men",
					Kross = "true",
					Treck = "true",
					Street = "true",
					Chopper = "true",
					Enduro = "true",
					Turing = "true"
				},
				new Profile {
					FirstName = "Иван",
					SecondName = "Иванов",
					Sex="men",
					Kross = "true",
					Treck = "true",
					Street = "true",
					Chopper = "true",
					Enduro = "true",
					Turing = "true"
				},
				new Profile {
					FirstName = "Иван",
					SecondName = "Иванов",
					Sex="men",
					Kross = "true",
					Treck = "true",
					Street = "true",
					Chopper = "true",
					Enduro = "true",
					Turing = "true"
				},
		};
			profiles.ForEach(std => context.Profiles.Add(std));
			context.SaveChanges();

			var indexes = new List<News>
				{
				new News {
				Title = "BMW S1000 RR",
				Date = DateTime.Parse("2011-07-01"),
				NewsText = "BMW S1000 RR  — спортивный мотоцикл (Супербайк) серийного производства BMW Motorrad. Мотоцикл был представлен в Мюнхене в апреле 2008 года. Разгон до 100 км/ч происходит за 3,1 с. Максимальная скорость мотоцикла 289 км/ч."
				},
					new News {
				Title = "BMW S1000 RR",
				Date = DateTime.Parse("2011-07-01"),
				NewsText = "BMW S1000 RR  — спортивный мотоцикл (Супербайк) серийного производства BMW Motorrad. Мотоцикл был представлен в Мюнхене в апреле 2008 года. Разгон до 100 км/ч происходит за 3,1 с. Максимальная скорость мотоцикла 289 км/ч."
				},
					new News {
				Title = "BMW S1000 RR",
				Date = DateTime.Parse("2011-07-01"),
				NewsText = "BMW S1000 RR  — спортивный мотоцикл (Супербайк) серийного производства BMW Motorrad. Мотоцикл был представлен в Мюнхене в апреле 2008 года. Разгон до 100 км/ч происходит за 3,1 с. Максимальная скорость мотоцикла 289 км/ч."
				},
		};
			indexes.ForEach(std => context.Newses.Add(std));
			context.SaveChanges();
		}
	}

}
