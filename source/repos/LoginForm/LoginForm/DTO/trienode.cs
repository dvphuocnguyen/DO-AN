using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LoginForm.DTO
{
    public class trienode
    {
        static int NUM_CHAR = 256;
        public char c;
        public trienode[] children;
        List<int> indexes;
        public bool terminal;
        public trienode(char c)
        {
            this.c = c;
            this.children = new trienode[NUM_CHAR];
            for(int i=0; i<NUM_CHAR; i++)
            {
                this.children[i] =null;
            }
            indexes= new List<int>();
            this.terminal = false;
        }
        public void insertNode(String s,int index)
        {
            indexes.Add(index);
            if(s.Length>0)
            {
                char fIndex = s[0];
                                
                if (children[s[0]] == null)
                {
                    children[s[0]] = new trienode(fIndex);  
                }
                children[fIndex].insertNode(s.Substring(1),index+1);
            }
        }
        public List<int> search(String s)
        {
            if(s.Length==0)
            {
                return indexes;
            }
            if(s[0]>=256||s[0]<0)
            {
                return null;
            }    
            if (children[s[0]] != null)
            {

                return children[s[0]].search(s.Substring(1));
            }
            else return null;
            

        }
        /*  // public void insert(string word, int index)
         //{
        //     trienode curr = root;
         //    char[] chars = word.ToCharArray();
         //    for (int i = 0; i < chars.Length; i++)
             {
                 if (curr.children[chars[i]] == null)
                 {
                     curr.children[chars[i]] = new trienode(chars[i]);
                     indexes.Add(chars[i]);
                 }
                 curr = curr.children[chars[i]];
             }
             curr.terminal = true;
         }*/


    }

}
