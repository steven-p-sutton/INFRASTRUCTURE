using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conductus.EXAMPLE.Model
{
    public class EExample : IExample
    {
        [JsonProperty("str")]
        public string Str 
        {
            get
            {
                throw new ExampleNotImplentedException(); 
            }
            
            set
            {
                throw new ExampleNotImplentedException(); 
            }
        }
        [JsonProperty("int")]
        public int Int 
        {
            get
            {
                throw new ExampleNotImplentedException();
            }
            set
            {
                throw new ExampleNotImplentedException();
            }
        }
        [JsonProperty("list")]
        public List<string> Repository 
        {
            get
            {
                throw new ExampleNotImplentedException();
            }
            set
            {
                throw new ExampleNotImplentedException();
            } 
        }
        public int Add(string item)
        {
            throw new ExampleNotImplentedException();
        }
        public string Remove(int idx)
        {
            throw new ExampleNotImplentedException();
        }
        public int Find(string item)
        {
            throw new ExampleNotImplentedException();
        }
    }
}
