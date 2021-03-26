using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Birds
{
    class birdList
    {
        string picfolder; //folder for images
        string folder; //the universal folder path that is passed from the "Program" class's Main method.
        List<Bird> bird; //list for the bird files
        public List<Bird> pubBirds { get; set; }
        string[] thePictures; //picture files list
        bool noBirds = false; //var for if there is no Bird
        List<string> brokenBirds = new List<string> { }; //list for files that dont work

        public birdList(string folderpathway, string imagepathway) //this constructor function gets the folder pathway, stores it, and stores a list of deserialized JSON files using the ImportJSON() method
        {
            picfolder = imagepathway;
            folder = folderpathway;
            thePictures = Directory.GetFiles(imagepathway);
            bird = ImportJSON(folderpathway);
        }





        public List<Bird> ImportJSON(string folderpathway) //this method uses a folder pathway string to get JSON files and deserialize them, it then returns a list of the deserialized JSON objects as well as a list of files that didnt work
        {

            string[] theBird = Directory.GetFiles(folderpathway);
            List<Bird> birdList = new List<Bird> { };


           Bird oneBird = new Bird();
            string jsondata = "";

            foreach (var bird in theBird)
            {
                jsondata = File.ReadAllText(bird);
                try //this try block is extremely important. It makes it so that no other try blocks are needed when dealing with these files because a list of proper JSON files is created and stored and the broken files are not used.
                {
                    oneBird = JsonSerializer.Deserialize<Bird>(jsondata); //if the file is not a JSON file that fits this format then it will not be added to the list
                    birdList.Add(oneBird);
                }
                catch (Exception ex)
                {
                    brokenBirds.Add(bird);
                }
            }


            if (birdList.Count == 0)//if there are no valid bird files in the folder, the program lets you know
            {

            }
            return birdList;//the list is returned... this list only contains valid bird files
        }



        public void SaveJSON(string title, string year, string runtime, string Image, string Sound, int id)//method for saving the JSON files. It does this by Serializing the JSON bird objects back to JSON files. All of the objects properties are parameters individually and nothing is returned
        {
            try //makes sure the program doesnt crash if the JSON file cant be saved to for some reason
            {
                string jsondata = "";

                Bird abird = bird[id];

                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                jsondata = JsonSerializer.Serialize(abird, jsonOptions);
                StreamWriter writer = new StreamWriter(folder + "\\" + abird.id + ".json");
                writer.Write(jsondata);
                writer.Close();
            }
            catch (Exception ex)
            {

            }


        }


        public List<string> TakeBird() //gets bird names
        {
            List<string> birdtitles = new List<string> { };

            foreach (Bird name in bird)
            {
                birdtitles.Add(name.Name);
            }

            return birdtitles;
        }

        public List<string> TakebirdImages() //gets bird images
        {
            List<string> birdtitles = new List<string> { };

            foreach (Bird name in bird)
            {
                birdtitles.Add(name.Image);
            }

            return birdtitles;
        }


        public Bird BirdSelectBird(int index) //lets you select a bird. Recieves an integer for the index and Returns a bird object
        {
            return bird[index];

        }

        public string SelectedImage(string id) //same as above but it returns a string image pathway instead
        {
           Bird thebird = new Bird{ };
            foreach (Bird mov in bird)
            {
                if (mov.id == id)
                {
                    thebird = mov;
                    break;
                }
            }
            try //if the image doesn't exist this will handle it
            {
                return picfolder + "\\" + thebird.id + ".jpg";
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public string SelectedImage(int num) //same as above but it returns a string image pathway instead
        {

            try //if the image doesn't exist this will handle it
            {
                return picfolder + "\\" + bird[num].id + ".jpg";
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void Update(string property, int num, int id) //this method just saves the information the user enters to a object file. It does not update it to the json file. It takes the information in string form, an integer telling it which property needs to be updated, and an integer that identifies which object needs to be updated. Nothing is returned
        {

            try //if there is some issue updating this will catch it, the only place where an error really could occur is in the rank so thats what the exception handles
            {
                if (num == 1)
                {
                    bird[id].id = property;
                }
                else if (num == 2)
                {
                    bird[id].Name = property;
                }
                else if (num == 3)
                {
                    bird[id].Family = property;
                }
                else if (num == 4)
                {
                    bird[id].Order = property;
                }
                else if (num == 5)
                {
                    bird[id].Image = property;
                }
                else if (num == 6)
                {
                    bird[id].Sound = property;
                }
            }
            catch (Exception ex)
            {
                if (num == 6)
                {
                   // bird[id].ranking = 0;
                }
            }

        }
        public bool empty()//this method returns a bool that says if the bird list is empty or not. There are
        {
            return noBirds;
        }

        public List<string> broken() //when called this method returns a list of the broken Bird
        {
            return brokenBirds;
        }

        public void delete(int num, string id) //delete function, it deletes the files and removes the object from the list. There are two parameters, although one could be used... the "id" parameter is a fail safe to make sure the right files are deleted, the object doesnt follow this method because the object is easier to replace if it deletes the wrong file
        {

            try //if the file can't be deleted this try block will catch it.. it wont do anything but atleast the program wont crash (yes i should have had some way of telling the user but I added this at the end and im too lazy at this point
            {

                File.Delete(picfolder + "\\" + id + ".jpg");
                File.Delete(folder + "\\" + id + ".json");

            }
            catch (Exception ex)
            {

            }
            bird.RemoveAt(num);


        }
        public void Addbird(string id, string name, string family, string order, string image, string sound) //adds a bird to the "Bird" list, the parameters are all the "Bird" parameter, nothing is returned
        {
           Bird onebird = new Bird();
            onebird.id = id;
            onebird.Name = name;
            onebird.Family = family;
            onebird.Order = order;
            onebird.Image = image;
            onebird.Sound = sound;
            bird.Add(onebird);

            for (int i = 0; i < bird.Count; i++)
            {
                if (bird[i].id == id)
                {
                    SaveJSON(onebird.Name, onebird.Family, onebird.Order, onebird.Image, onebird.Sound, i);
                }

            }
        }
        public void AddImage(string OGpath, string id) //copys an image and places it in the file, it needs the old file path and the new id/filename as parameters, nothing is returned but a new image is placed in the images folder
        {
            File.Copy(OGpath, picfolder + "\\" + id + ".jpg");
        }

        public List<Bird> ReturnbirdList() //for ranking Bird, no return or parameters
        {
            List<Bird> Bird22 = new List<Bird> { };

            foreach (Bird mov in bird)
            {
                Bird22.Add(mov);
            }
            return Bird22;
        }

        public void SaveJSON(List<Bird> movlist) //saves all of the json files, pretty basic
        {
            foreach (Bird mov in movlist)
            {
                string jsondata = "";

                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                jsondata = JsonSerializer.Serialize(mov, jsonOptions);
                StreamWriter writer = new StreamWriter(folder + "\\" + mov.id + ".json");
                writer.Write(jsondata);
                writer.Close();
            }
        }
    }
}
