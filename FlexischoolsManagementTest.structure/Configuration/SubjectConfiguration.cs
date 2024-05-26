using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FlexischoolsManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Infrastructure.Configuration
{
    internal sealed class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(subject => subject.Id);

            builder.Property(subject => subject.Id).ValueGeneratedOnAdd();

            builder.Property(subject => subject.Name).HasMaxLength(60);

            builder.HasMany(subject => subject.Lectures);

            builder.HasMany(m => m.EnrolledStudents);
        }
    }
}
