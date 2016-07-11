using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Text;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        public string Author { get; set; }
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public Comment(String content, IUser user): this(content)
        {
            this.Author = user.Username;
        }

        public string Content
        {
            get
            {
                return this.content;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength,
                                             String.Format(Constants.StringMustBeBetweenMinAndMax,
                                            "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("----------");
            result.AppendLine(this.Content);
            result.AppendLine("User: " + this.Author);
            result.AppendLine("----------");
            
            return result.ToString();
        }
    }
}
