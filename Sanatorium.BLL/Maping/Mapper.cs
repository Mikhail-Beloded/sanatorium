﻿using AutoMapper;
using Sanatorium.BLL.DTOs;
using Sanatorium.DAL.Entities;
using Sanatorium.DAL.Paging;

namespace Sanatorium.BLL.Maping
{
    public class Mapper
    {
        private readonly IMapper _mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<DoctorDto, Doctor>();
            cfg.CreateMap<Doctor, DoctorDto>();

            cfg.CreateMap<Illness, IllnessDto>();
            cfg.CreateMap<IllnessDto, Illness>();

            cfg.CreateMap<IllnessPatient, IllnessPatientDto>();
            cfg.CreateMap<IllnessPatientDto, IllnessPatient>();

            cfg.CreateMap<Patient, PatientDto>();
            cfg.CreateMap<PatientDto, Patient>();

            cfg.CreateMap<Procedure, ProcedureDto>();
            cfg.CreateMap<ProcedureDto, Procedure>();

            cfg.CreateMap<ProcedureIllness, ProcedureIllnessDto>();
            cfg.CreateMap<ProcedureIllnessDto, ProcedureIllness>();

            cfg.CreateMap<ProcedureReciept, ProcedureRecieptDto>();
            cfg.CreateMap<ProcedureRecieptDto, ProcedureReciept>();

            cfg.CreateMap<Reciept, RecieptDto>();
            cfg.CreateMap<RecieptDto, Reciept>();

            cfg.CreateMap<Room, RoomDto>();
            cfg.CreateMap<RoomDto, Room>();

            cfg.CreateMap<Voucher, VoucherDto>();
            cfg.CreateMap<VoucherDto, Voucher>();

        }).CreateMapper();

        public Patient MapFromDto(PatientDto patientDto)
        {
            return _mapper.Map<Patient>(patientDto);
        }

        public PatientDto MapToDto(Patient patient)
        {
            return _mapper.Map<PatientDto>(patient);
        }

        public PagedList<PatientDto> MapToDto(PagedList<Patient> patients)
        {
            return _mapper.Map<PagedList<PatientDto>>(patients);
        }

    }
}
