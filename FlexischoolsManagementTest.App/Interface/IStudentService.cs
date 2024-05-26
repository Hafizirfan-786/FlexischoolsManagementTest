using FlexischoolsManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Application.Contract
{
    public interface IStudentService
    {
        Task<StudentDto> AddAsync(StudentAdditionDto studentForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<StudentDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<StudentDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task<IEnumerable<StudentDto>> RetrieveAsync(int subjectId, CancellationToken cancellationToken = default);
    }
}
