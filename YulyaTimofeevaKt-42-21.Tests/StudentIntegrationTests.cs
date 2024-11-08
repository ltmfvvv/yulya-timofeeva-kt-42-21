﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YulyaTimofeevaKt_42_21.Database;
using YulyaTimofeevaKt_42_21.Interfaces.StudentsInterfaces;
using YulyaTimofeevaKt_42_21.Models;
using Microsoft.EntityFrameworkCore;

namespace YulyaTimofeevaKt_42_21.Tests
{
    public class StudentIntegrationTests
    {
        public readonly DbContextOptions<StudentDbContext> _dbContextOptions;

        public StudentIntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<StudentDbContext>()
            .UseInMemoryDatabase(databaseName: "student_db")
            .Options;
        }

        [Fact]
        public async Task GetStudentsByGroupAsync_KT4221_TwoObjects()
        {
            // Arrange
            var ctx = new StudentDbContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var groups = new List<Group>
            {
                new Group
                {
                    GroupName = "КТ-42-21"
                },
                new Group
                {
                    GroupName = "КТ-41-21"
                },
                new Group
                {
                    GroupName = "КТ-31-21"
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);

            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "A",
                    LastName = "A",
                    Middlename = "A",
                    GroupID = 3,
                    DeletionStatus = false,
                },
                new Student
                {
                    FirstName = "A",
                    LastName = "A",
                    Middlename = "A",
                    GroupID = 3,
                    DeletionStatus = true,
                },
                new Student
                {
                    FirstName = "A",
                    LastName = "A",
                    Middlename = "B",
                    GroupID = 3,
                    DeletionStatus = true,
                }
            };
            await ctx.Set<Student>().AddRangeAsync(students);

            await ctx.SaveChangesAsync();

            var filterIDGroup = new Filters.StudentFilters.StudentGroupFilter
            {
                GroupName = "КТ-31-21"
            };
            var IdGroupsResult = await studentService.GetStudentsByGroupAsync(filterIDGroup, CancellationToken.None);

            Assert.Equal(3, IdGroupsResult.Length);

            //var filterFIO = new Filters.StudentFilters.StudentFIOAllFilter
            //{
            //    Name = "A",
            //    LastName = "A",
            //    MiddleName ="A",
            //};
            //var studentsResult = await studentService.GetStudentsByFIOAllAsync(filterFIO, CancellationToken.None);

            //Assert.Equal(2, studentsResult.Length);

            //var filterDEL = new Filters.StudentFilters.StudentDeletionStatusFilter
            //{
            //    DeletionStatus = true
            //};
            //var studentsDelResult = await studentService.GetStudentsByDeletionStatusAsync(filterDEL, CancellationToken.None);

            // Assert
            //Assert.Equal(2, studentsDelResult.Length);
        }
    }
}