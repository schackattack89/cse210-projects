public class VerseGenerator{
    private List<string> _verses;
    /*public void ImportAllVerses()
    {
        _verses = new List<string>();
        string filename = "lds-scriptures.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            _verses.Add(line);
        }
    }*/
    public string GetSingleVerse(string book, int chapter, int start){
        _verses = new List<string>();
        string filename = "lds-scriptures.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        
        List<string> thisBook = new List<string>();
        List<string> thisChapter = new List<string>();
        string displayString = "";
        if(book.ToLower()=="doctrine and covenants"){
            foreach(string line in lines){
                if ((line.Split("     ")[0].ToLower()).Contains(book.ToLower())){
                    thisBook.Add(line);
                }
            }
            foreach(string line in thisBook){
                string chapVerseNum = line.Split(" ")[3];
                int preColon = Convert.ToInt32(chapVerseNum.Split(":")[0]);
                if(preColon == chapter){
                    thisChapter.Add(line);
                }
            }
            foreach(string verseStart in thisChapter){
                string verseStartNum = verseStart.Split("     ")[0];
                int postColon = Convert.ToInt32(verseStartNum.Split(":")[1]);
                if(postColon == start){
                    displayString = verseStart;
                    break;
                }
            }
            
            displayString = displayString.Split("     ")[1];
        }
        else if(book.Contains('1')||book.Contains('2')||book.Contains('3')||book.Contains('4')){
            foreach(string line in lines){
                if ((line.Split("     ")[0].ToLower()).Contains(book.ToLower())){
                    thisBook.Add(line);
                }
            }
            foreach(string line in thisBook){
                string chapVerseNum = line.Split(" ")[2];
                int preColon = Convert.ToInt32(chapVerseNum.Split(":")[0]);
                if(preColon == chapter){
                    thisChapter.Add(line);
                }
            }
            foreach(string verseStart in thisChapter){
                string verseStartNum = verseStart.Split("     ")[0];
                int postColon = Convert.ToInt32(verseStartNum.Split(":")[1]);
                if(postColon == start){
                    displayString = verseStart;
                    break;
                }
            }
            
            displayString = displayString.Split("     ")[1];
        }
        else{
            foreach(string line in lines){
                if (line.Split(" ")[0].ToLower() == book.ToLower()){
                    thisBook.Add(line);
                }
            }
            foreach(string line in thisBook){
                string chapVerseNum = line.Split(" ")[1];
                int preColon = Convert.ToInt32(chapVerseNum.Split(":")[0]);
                if(preColon == chapter){
                    thisChapter.Add(line);
                }
            }
            foreach(string verseStart in thisChapter){
                string verseStartNum = verseStart.Split(":")[1];
                int postColon = Convert.ToInt32(verseStartNum.Split()[0]);
                if(postColon == start){
                    displayString = verseStart;
                    break;
                }
            }
            
            displayString = displayString.Split("     ")[1];
        }
        return displayString;

    }
    public string GetMultipleVerse(string book, int chapter, int start, int end){
        _verses = new List<string>();
        string filename = "lds-scriptures.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        
        List<string> thisBook = new List<string>();
        List<string> thisChapter = new List<string>();
        string displayString = "";
        int indexOfStarter = 0;
        int numberOfVerses = end - start + 1;
        if(book.ToLower()=="doctrine and covenants"){
            foreach(string line in lines){
                if ((line.Split("     ")[0].ToLower()).Contains(book.ToLower())){
                    thisBook.Add(line);
                }
            }
            foreach(string line in thisBook){
                string chapVerseNum = line.Split(" ")[3];
                int preColon = Convert.ToInt32(chapVerseNum.Split(":")[0]);
                if(preColon == chapter){
                    thisChapter.Add(line);
                }
            }
            foreach(string verseStart in thisChapter){
                string verseStartNum = verseStart.Split("     ")[0];
                int postColon = Convert.ToInt32(verseStartNum.Split(":")[1]);
                if(postColon == start){
                    displayString = verseStart;
                    break;
                }
                indexOfStarter++;
            }
            
            displayString = displayString.Split("     ")[1];
        }
        else if(book.Contains('1')||book.Contains('2')||book.Contains('3')||book.Contains('4')){
            foreach(string line in lines){
                if ((line.Split("     ")[0].ToLower()).Contains(book.ToLower())){
                    thisBook.Add(line);
                }
            }
            foreach(string line in thisBook){
                string chapVerseNum = line.Split(" ")[2];
                int preColon = Convert.ToInt32(chapVerseNum.Split(":")[0]);
                if(preColon == chapter){
                    thisChapter.Add(line);
                }
            }
            foreach(string verseStart in thisChapter){
                string verseStartNum = verseStart.Split("     ")[0];
                int postColon = Convert.ToInt32(verseStartNum.Split(":")[1]);
                if(postColon == start){
                    displayString = verseStart;
                    break;
                }
                indexOfStarter++;
            }
            
            displayString = displayString.Split("     ")[1];
        }
        else{
            foreach(string line in lines){
                if (line.Split(" ")[0].ToLower() == book.ToLower()){
                    thisBook.Add(line);
                }
            }
            foreach(string line in thisBook){
                string chapVerseNum = line.Split(" ")[1];
                int preColon = Convert.ToInt32(chapVerseNum.Split(":")[0]);
                if(preColon == chapter){
                    thisChapter.Add(line);
                }
            }
            foreach(string verseStart in thisChapter){
                string verseStartNum = verseStart.Split(":")[1];
                int postColon = Convert.ToInt32(verseStartNum.Split()[0]);
                if(postColon == start){
                    displayString = verseStart;
                    break;
                }
                indexOfStarter++;
            }
        }
        string beginningText = thisChapter[indexOfStarter];
        string beginningTextTrimmed = beginningText.Split("     ")[1];
        string middleText = thisChapter[(indexOfStarter+1)];
        string middleTextTrimmed = middleText.Split("     ")[1];
        string endText = thisChapter[(indexOfStarter+2)];
        string endTextTrimmed = endText.Split("     ")[1];
        if(numberOfVerses == 1){
            displayString = beginningTextTrimmed;
        }
        else if(numberOfVerses == 2){
            displayString = beginningTextTrimmed+" "+middleTextTrimmed;
        }
        else if(numberOfVerses == 3){
            displayString = beginningTextTrimmed+" "+middleTextTrimmed+" "+endTextTrimmed;
        }
        else{
            Console.WriteLine("You can only practice up to 3 verses at once. Goodbye.");
            System.Environment.Exit(1);
        }
        return displayString;

    }
}