/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27/10/2021 16:01:32                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASIGNATURA') and o.name = 'FK_ASIGNATU_REFERENCE_CARRERA')
alter table ASIGNATURA
   drop constraint FK_ASIGNATU_REFERENCE_CARRERA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASIGNATURA') and o.name = 'FK_ASIGNATU_REFERENCE_ESCUELA')
alter table ASIGNATURA
   drop constraint FK_ASIGNATU_REFERENCE_ESCUELA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASIGNATURA') and o.name = 'FK_ASIGNATU_REFERENCE_HORARIO')
alter table ASIGNATURA
   drop constraint FK_ASIGNATU_REFERENCE_HORARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CATALOGO') and o.name = 'FK_CATALOGO_REFERENCE_HORARIO')
alter table CATALOGO
   drop constraint FK_CATALOGO_REFERENCE_HORARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CATALOGO') and o.name = 'FK_CATALOGO_REFERENCE_LOCAL')
alter table CATALOGO
   drop constraint FK_CATALOGO_REFERENCE_LOCAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOCENTE_USUARIO') and o.name = 'FK_DOCENTE__REFERENCE_DOCENTE')
alter table DOCENTE_USUARIO
   drop constraint FK_DOCENTE__REFERENCE_DOCENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOCENTE_USUARIO') and o.name = 'FK_DOCENTE__REFERENCE_USUARIO')
alter table DOCENTE_USUARIO
   drop constraint FK_DOCENTE__REFERENCE_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOCAL') and o.name = 'FK_LOCAL_REFERENCE_GALERIA')
alter table LOCAL
   drop constraint FK_LOCAL_REFERENCE_GALERIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERMISO_ROLES') and o.name = 'FK_PERMISO__REFERENCE_ROL')
alter table PERMISO_ROLES
   drop constraint FK_PERMISO__REFERENCE_ROL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERMISO_ROLES') and o.name = 'FK_PERMISO__REFERENCE_PERMISO')
alter table PERMISO_ROLES
   drop constraint FK_PERMISO__REFERENCE_PERMISO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVA') and o.name = 'FK_RESERVA_REFERENCE_DOCENTE')
alter table RESERVA
   drop constraint FK_RESERVA_REFERENCE_DOCENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SOLICITUD_RESERVA') and o.name = 'FK_SOLICITU_REFERENCE_DOCENTE')
alter table SOLICITUD_RESERVA
   drop constraint FK_SOLICITU_REFERENCE_DOCENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SOLICITUD_RESERVA') and o.name = 'FK_SOLICITU_REFERENCE_LOCAL')
alter table SOLICITUD_RESERVA
   drop constraint FK_SOLICITU_REFERENCE_LOCAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO_ROL') and o.name = 'FK_USUARIO__REFERENCE_USUARIO')
alter table USUARIO_ROL
   drop constraint FK_USUARIO__REFERENCE_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO_ROL') and o.name = 'FK_USUARIO__REFERENCE_ROL')
alter table USUARIO_ROL
   drop constraint FK_USUARIO__REFERENCE_ROL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ASIGNATURA')
            and   type = 'U')
   drop table ASIGNATURA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CARRERA')
            and   type = 'U')
   drop table CARRERA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATALOGO')
            and   type = 'U')
   drop table CATALOGO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOCENTE')
            and   type = 'U')
   drop table DOCENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOCENTE_USUARIO')
            and   type = 'U')
   drop table DOCENTE_USUARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESCUELA')
            and   type = 'U')
   drop table ESCUELA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GALERIA')
            and   type = 'U')
   drop table GALERIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HORARIO')
            and   type = 'U')
   drop table HORARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOCAL')
            and   type = 'U')
   drop table LOCAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERMISO')
            and   type = 'U')
   drop table PERMISO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERMISO_ROLES')
            and   type = 'U')
   drop table PERMISO_ROLES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVA')
            and   type = 'U')
   drop table RESERVA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROL')
            and   type = 'U')
   drop table ROL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SOLICITUD_RESERVA')
            and   type = 'U')
   drop table SOLICITUD_RESERVA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO_ROL')
            and   type = 'U')
   drop table USUARIO_ROL
go

/*==============================================================*/
/* Table: ASIGNATURA                                            */
/*==============================================================*/
create table ASIGNATURA (
   CODIGO_MATERIA       varchar(7)           not null,
   CODIGO_CARRERA       varchar(6)           null,
   COD__ESCUELA         varchar(15)          null,
   ID                   int                  null,
   CORRELATIVO_MATERIA  int                  not null,
   NOMBRE_MATERIA       varchar(50)          not null,
   UNIDAD_VALORATIVA    int                  not null,
   TIPO_MATERIA         varchar(15)          not null,
   PRE_REQUISITO        int                  not null,
   CICLO                varchar(5)           not null,
   constraint PK_ASIGNATURA primary key (CODIGO_MATERIA)
)
go

/*==============================================================*/
/* Table: CARRERA                                               */
/*==============================================================*/
create table CARRERA (
   CODIGO_CARRERA       varchar(6)           not null,
   NOMBRE_CARRERA       varchar(100)         not null,
   constraint PK_CARRERA primary key (CODIGO_CARRERA)
)
go

/*==============================================================*/
/* Table: CATALOGO                                              */
/*==============================================================*/
create table CATALOGO (
   ID_CATALOGO          int         identity(1,1) not null,
   ID                   int                  null,
   CODIGO_LOCAL         varchar(10)          null,
   constraint PK_CATALOGO primary key (ID_CATALOGO)
)
go

/*==============================================================*/
/* Table: DOCENTE                                               */
/*==============================================================*/
create table DOCENTE (
   DUI                  varchar(10)          not null,
   NOMBRE_DOCENTE       varchar(50)          not null,
   APELLIDO_DOCENTE     varchar(50)          not null,
   NIT                  varchar(17)          not null,
   FECHA_NACIMIENTO     date                 not null,
   ESTADO_ACTIVIDAD     varchar(9)           not null,
   constraint PK_DOCENTE primary key (DUI)
)
go

/*==============================================================*/
/* Table: DOCENTE_USUARIO                                       */
/*==============================================================*/
create table DOCENTE_USUARIO (
   DUI                  varchar(10)          null,
   ID_USUARIO           int                  null
)
go

/*==============================================================*/
/* Table: ESCUELA                                               */
/*==============================================================*/
create table ESCUELA (
   COD__ESCUELA         varchar(15)          not null,
   NOMBRE_ESCUELA       varchar(50)          not null,
   constraint PK_ESCUELA primary key (COD__ESCUELA)
)
go

/*==============================================================*/
/* Table: GALERIA                                               */
/*==============================================================*/
create table GALERIA (
   ID                   int        identity (1,1)          not null,
   NOMBRE_FOTO          varchar(50)          not null,
   constraint PK_GALERIA primary key (ID)
)
go

/*==============================================================*/
/* Table: HORARIO                                               */
/*==============================================================*/
create table HORARIO (
   ID                   int                identity (1,1)  not null,
   HORA                 time                 not null,
   DIA                  datetime             not null,
   constraint PK_HORARIO primary key (ID)
)
go

/*==============================================================*/
/* Table: LOCAL                                                 */
/*==============================================================*/
create table LOCAL (
   CODIGO_LOCAL         varchar(10)          not null,
   ID                   int                  null,
   EDIFICIO             varchar(50)          not null,
   PLANTA               varchar(25)          not null,
   UBICACION            varchar(Max)         null,
   constraint PK_LOCAL primary key (CODIGO_LOCAL)
)
go

/*==============================================================*/
/* Table: PERMISO                                               */
/*==============================================================*/
create table PERMISO (
   ID_PERMISO           int            identity (1,1)      not null,
   NAME_PERMISO         varchar(50)          null,
   SLUG_PERMISO         varchar(50)          null,
   DESCRIPCION_PERMISO  varchar(50)          null,
   constraint PK_PERMISO primary key (ID_PERMISO)
)
go

/*==============================================================*/
/* Table: PERMISO_ROLES                                         */
/*==============================================================*/
create table PERMISO_ROLES (
   ROL_ID               int                  null,
   ID_PERMISO           int                  null
)
go

/*==============================================================*/
/* Table: RESERVA                                               */
/*==============================================================*/
create table RESERVA (
   CODIGO_DE_RESERVA    varchar(50)          not null,
   DUI                  varchar(10)          null,
   FECHA_ACEPTADA       date                 not null,
   constraint PK_RESERVA primary key (CODIGO_DE_RESERVA)
)
go

/*==============================================================*/
/* Table: ROL                                                   */
/*==============================================================*/
create table ROL (
   ROL_ID               int              identity (1,1)    not null,
   NOMBRE_ROL           varchar(50)          null,
   SLUG_ROL             varchar(50)          null,
   DESCRIPCION          varchar(max)         null,
   constraint PK_ROL primary key (ROL_ID)
)
go

/*==============================================================*/
/* Table: SOLICITUD_RESERVA                                     */
/*==============================================================*/
create table SOLICITUD_RESERVA (
   ID_SOLUCITUD         int                  not null,
   DUI                  varchar(10)          null,
   CODIGO_LOCAL         varchar(10)          null,
   FECHA_INGRESO        date                 null,
   APROBADO             bit                  null,
   constraint PK_SOLICITUD_RESERVA primary key (ID_SOLUCITUD)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID_USUARIO           int               identity (1,1)   not null,
   NOMBRE               varchar(50)          null,
   EMAIL                varchar(50)          null,
   PASWORD              varbinary(max)               null,
   ke_y                 varbinary(max)            null,
   VI                   varbinary(max)        null,
     constraint PK_USUARIO primary key (ID_USUARIO)
)
go

/*==============================================================*/
/* Table: USUARIO_ROL                                           */
/*==============================================================*/
create table USUARIO_ROL (
   ID_USUARIO           int                  null,
   ROL_ID               int                  null
)
go

alter table ASIGNATURA
   add constraint FK_ASIGNATU_REFERENCE_CARRERA foreign key (CODIGO_CARRERA)
      references CARRERA (CODIGO_CARRERA)
go

alter table ASIGNATURA
   add constraint FK_ASIGNATU_REFERENCE_ESCUELA foreign key (COD__ESCUELA)
      references ESCUELA (COD__ESCUELA)
go

alter table ASIGNATURA
   add constraint FK_ASIGNATU_REFERENCE_HORARIO foreign key (ID)
      references HORARIO (ID)
go

alter table CATALOGO
   add constraint FK_CATALOGO_REFERENCE_HORARIO foreign key (ID)
      references HORARIO (ID)
go

alter table CATALOGO
   add constraint FK_CATALOGO_REFERENCE_LOCAL foreign key (CODIGO_LOCAL)
      references LOCAL (CODIGO_LOCAL)
go

alter table DOCENTE_USUARIO
   add constraint FK_DOCENTE__REFERENCE_DOCENTE foreign key (DUI)
      references DOCENTE (DUI)
go

alter table DOCENTE_USUARIO
   add constraint FK_DOCENTE__REFERENCE_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table LOCAL
   add constraint FK_LOCAL_REFERENCE_GALERIA foreign key (ID)
      references GALERIA (ID)
go

alter table PERMISO_ROLES
   add constraint FK_PERMISO__REFERENCE_ROL foreign key (ROL_ID)
      references ROL (ROL_ID)
go

alter table PERMISO_ROLES
   add constraint FK_PERMISO__REFERENCE_PERMISO foreign key (ID_PERMISO)
      references PERMISO (ID_PERMISO)
go

alter table RESERVA
   add constraint FK_RESERVA_REFERENCE_DOCENTE foreign key (DUI)
      references DOCENTE (DUI)
go

alter table SOLICITUD_RESERVA
   add constraint FK_SOLICITU_REFERENCE_DOCENTE foreign key (DUI)
      references DOCENTE (DUI)
go

alter table SOLICITUD_RESERVA
   add constraint FK_SOLICITU_REFERENCE_LOCAL foreign key (CODIGO_LOCAL)
      references LOCAL (CODIGO_LOCAL)
go

alter table USUARIO_ROL
   add constraint FK_USUARIO__REFERENCE_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table USUARIO_ROL
   add constraint FK_USUARIO__REFERENCE_ROL foreign key (ROL_ID)
      references ROL (ROL_ID)
go

