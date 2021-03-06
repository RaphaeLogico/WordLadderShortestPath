﻿using System.Collections.Generic;

namespace WordLadder.Data
{
    public interface IFileHandler
    {
        /// <summary>
        /// List of Words
        /// </summary>
        public IEnumerable<string> WordList { get; set; }

        /// <summary>
        /// Return a List of words generated before the calculation of shortest path between Start Word and End Word provided
        /// </summary>        
        /// <param name="wordLenght">Length of words to filter</param>        
        /// <param name="path">Path to tests</param>        
        public IEnumerable<string> LoadDictionaryContent(int wordLenght, string path = "");

        /// <summary>
        /// Save the shortest path in a file
        /// </summary>
        /// <param name="filePath">Path of the file</param>
        /// <param name="resultList">List of the words to be saved</param>
        public void SaveOutputFile(string filePath, IEnumerable<string> resultList);

    }
}
