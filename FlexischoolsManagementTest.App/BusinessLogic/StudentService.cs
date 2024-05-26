using Mapster;
using FlexischoolsManagement.Application.Contract;
using FlexischoolsManagement.Application.DTOs;
using FlexischoolsManagement.Domain.Entities;
using FlexischoolsManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Application.Logic
{
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository _repositoryManager;

        public StudentService(IGenericRepository repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<StudentDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var students = await _repositoryManager.StudentRepository.ListAsync(cancellationToken);

            return students.Adapt<IEnumerable<StudentDto>>();
        }

        public async Task<StudentDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var students = await _repositoryManager.StudentRepository.GetByIdAsync(id, cancellationToken);

            return students.Adapt<StudentDto>();
        }

        public async Task<StudentDto> AddAsync(StudentAdditionDto studentForCreationDto, CancellationToken cancellationToken = default)
        {
            var student = studentForCreationDto.Adapt<Student>();

            _repositoryManager.StudentRepository.Add(student);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return student.Adapt<StudentDto>();
        }

        public async Task<IEnumerable<StudentDto>> RetrieveAsync(int subjectId, CancellationToken cancellationToken = default)
        {
            var students = await _repositoryManager.StudentRepository.GetBySubjectIdAsync(subjectId, cancellationToken);

            return students.Adapt<IEnumerable<StudentDto>>();
        }
    }
}
