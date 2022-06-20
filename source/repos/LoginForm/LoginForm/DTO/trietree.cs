using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class trietree
    {
        public trienode root;
        
        
     
        public trietree(string txt)
        {
            this.root=new trienode('\0');
           
            
            for(int i=0;i<txt.Length;i++)
            {
                root.insertNode(txt.Substring(i), i);
            }             
        }
        public List<int> search_tree(string pat)
        {
            Console.WriteLine("cc");
            List<int> result=root.search(pat);
            Console.WriteLine("aa");
            if (result == null)
                return null; 
            else
            {
                for(int i=0;i< result.Count;i++)
                {
                    result[i]-=pat.Length;
                }
                return result;
            }
                
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
       
/*        private trienode getnode(String word)
        {
            trienode curr=root; 
            char [] chars = word.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if (curr.children[chars[i]] == null)
                    return null;
                curr = curr.children[chars[i]];
            }
            
            return curr;
        }
        public Boolean startsWith(String prefix)
        {
            return getnode(prefix) != null;
        }
        public Boolean search(String word)
        {
            trienode node=getnode(word);
            return node != null && node.terminal;
        }
        bool isLeafNode(trienode node)
        {
           
            return node.terminal!=false;
        }
        */
     /*   private void dfs(trienode node,char[] str,int level)
        {
           
                trienode temp = node;
                if (isLeafNode(temp))
                {
                    str[level] = '\0';
                    Console.WriteLine(str);
                }
                foreach (char i in indexes.Distinct())
                {
                    
                    if (node.children[i] != null)
                    {
                        str[level] = i;
                                                
                        dfs(node.children[i],str,level+1);
                    }

                }
            


        }*/
       /* public string printallwithprefix(String prefix)
        {
            if(startsWith(prefix))
            {
                   trienode node = getnode(prefix);
                    char[] str=new char[20];
                    dfs(node,str,0);
                 
                    chuoi = string.Join("", str);
                
                return chuoi;
            }
            else
            {
                Console.WriteLine("gg");
                return null;
            }
        }*/
   
       
    }
}
