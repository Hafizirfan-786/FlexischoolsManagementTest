using FlexischoolsManagement.Application.DTOs;

namespace FlexischoolsManagement.Application.Contract
{
    public interface ILectureService
    {
        Task<LectureDto> AddAsync(LectureAdditionDto LectureForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<LectureDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<LectureDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
