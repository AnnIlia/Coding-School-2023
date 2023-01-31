using EF.Course.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Course.Orm.Configurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>


    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todo"); //name of dbSet
            //object? ConfigureKey(Todo todo)
            //{
            //    return todo.Id;
            //}
            builder.HasKey(todo => todo.Id); //lamda expr

            builder.Property(todo => todo.Id).ValueGeneratedOnAdd(); //generator value of 
            //guid: is to do new guid
            //generator: define how new creations i want
            builder.Property(todo => todo.Title).HasMaxLength(50);


        }
    }
}
