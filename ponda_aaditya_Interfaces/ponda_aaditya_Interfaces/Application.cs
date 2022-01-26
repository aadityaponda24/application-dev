/*
 * Name : Aaditya Ponda
 * Date : 19 Jan 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    class Application
    {
        private List<Animal> _animals;

        private List<string> _animalsList;
        private Menu _animalsMenu;

        private List<string> _activityList;
        private Menu _activityMenu;

        public Application()
        {
            int menuChoice;
            int activityChoice;
            welcomeUser();
            menuChoice = getMenuChoice(_animalsMenu, _animals.Count+1);
            Animal animal;

            while(menuChoice != 7)
            {
                animal = _animals.ElementAt(menuChoice - 1);
                Menu.DisplayContent($"You have selected a {animal.Species}");

                activityChoice = getMenuChoice(_activityMenu, 5);
                while(activityChoice != 5)
                {
                    switch(activityChoice)
                    {
                        case 1: trainAnimal(animal); break;
                        case 2: feedAnimal(animal); break;
                        case 3: signalAnimal(animal); break;
                        case 4: listenAnimal(animal); break;
                    }

                    activityChoice = getMenuChoice(_activityMenu, 5);
                }
                menuChoice = getMenuChoice(_animalsMenu, _animals.Count+1);
            }
            

        }

        private void welcomeUser()
        {
            Menu.DisplayHeader("Welcome to the Zoo");
            _animals = new List<Animal>() { new Fish(), new Lion(), new Monkey(), new Parrot(), new Sheep(), new Snake() };

            _animalsList = new List<string>{ "Fish", "Lion", "Monkey (trainable)","Parrot (trainable)","Sheep (trainable)", "Snake","Exit"};
            _animalsMenu = new Menu(_animalsList);

            _activityList = new List<string> { "Train the animal in a new behavior.","Feed animal a treat.","Signal to the animal to perform a behavior.", "Listen to the animal to make a noise", "Select a different animal"};
            _activityMenu = new Menu(_activityList);
        }

        private int getMenuChoice(Menu menu, int menuCount)
        {
            menu.displayMenu(1);
            int menuChoice = Validation.ValidateRange("Please enter your selection: ", 1, menuCount);
            return menuChoice;
        }

        private void trainAnimal(Animal animal)
        {
            if(animal is ITrainable)
            {
                ITrainable trainable = animal as ITrainable;

                string behavior = Validation.ValidateString("What new behavior are you training the animal to do? ");
                string signal = Validation.ValidateString("What signal will you use to ask the animal to perform this new behavior? ");
                string result = trainable.Train(signal, behavior);

                Menu.DisplayContent(result);
            }
            else
            {
                Menu.DisplayContent($"{animal.Species} is not Trainable!");
            }
        }

        private void feedAnimal(Animal animal)
        {
            Menu.DisplayContent(animal.Eat());
        }

        private void signalAnimal(Animal animal)
        {
            if (animal is ITrainable)
            {
                ITrainable trainable = animal as ITrainable;
                
                List<string> signals = trainable.Behaviors.Keys.ToList();
                Menu signalMenu = new Menu(signals);

                signalMenu.displayMenu(1);

                int signalChoice = Validation.ValidateRange("What signal will you use? ",1,signals.Count);
                string signal = signals[signalChoice - 1];
                string result = trainable.Perform(signal);

                Menu.DisplayContent(result);
            }
            else
            {
                Menu.DisplayContent($"{animal.Species} is not Trainable!");
            }
        }

        private void listenAnimal(Animal animal)
        {
            Menu.DisplayContent(animal.MakeNoise());
        }
    }
}
