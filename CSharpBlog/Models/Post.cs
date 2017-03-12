using System;
using System.Collections.Generic;

namespace CSharpBlog.Models
{

    public class Post
    {
        public virtual int Id
        { get; set; }

        public virtual string Title
        { get; set; }

        public virtual string ShortDescription
        { get; set; }

        public virtual string Description
        { get; set; }

        public virtual string Meta
        { get; set; }

        public virtual string UrlSlug
        { get; set; }

        public virtual bool Published
        { get; set; }

        public virtual DateTime PostedOn
        {
            get
            {
                return this.postedOn.HasValue
                   ? this.postedOn.Value
                   : DateTime.Now;
            }

            set { this.postedOn = value; }
        }

        private DateTime? postedOn = null;

        public virtual DateTime? Modified
        { get; set; }

        public virtual Category Category
        { get; set; }

        public virtual IList<Tag> Tags
        { get; set; }
    }
}