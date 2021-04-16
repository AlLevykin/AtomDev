
DROP SCHEMA IF EXISTS dicts CASCADE;
CREATE SCHEMA dicts;

--НЕОБХОДИМО! муниципальные образования (муниципальные районы и городские округа)
CREATE TABLE dicts.municipal_units(
    id_municipal_units      SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    TEXT NOT NULL,
    address                 CHAR(50),
    coords                  JSONB
);
--органы управления
CREATE TABLE dicts.authorities(
    id_authorities          SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    TEXT NOT NULL

);

--типы органов управления
CREATE TABLE dicts.types_authorities(
    id_types_authorities    SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    TEXT NOT NULL,
    id_authorities          INT,

    FOREIGN KEY (id_authorities) REFERENCES dicts.authorities (id_authorities) ON DELETE CASCADE
);

--НЕОБХОДИМО! образовательные организации
CREATE TABLE dicts.edu_orgs(
    id_edu_orgs             SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    TEXT NOT NULL,
    address                 CHAR(50),
    phone                   CHAR(20),
    latitude                DECIMAL(9, 6),
    longitude               DECIMAL(9, 6),
    license                 BOOLEAN,
    state_accreditaion      BOOLEAN,
    id_municipal_units      INT,
    id_authorities          INT,
    id_types_authorities    INT,

    FOREIGN KEY (id_municipal_units) REFERENCES dicts.municipal_units (id_municipal_units) ON DELETE CASCADE,
    FOREIGN KEY (id_authorities) REFERENCES dicts.authorities (id_authorities) ON DELETE CASCADE,
    FOREIGN KEY (id_types_authorities) REFERENCES dicts.types_authorities (id_types_authorities) ON DELETE CASCADE

);
--категории по кадрам
CREATE TABLE dicts.staff_category(
    id_staff_category       SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    CHAR(50)
);

--второй уровень категорий кадров
CREATE TABLE dicts.cat_2nd_lvl(
      id_cat_2nd_lvl        SERIAL UNIQUE PRIMARY KEY NOT NULL,
      name                  CHAR(50),
      id_staff_category     INT,
      FOREIGN KEY (id_staff_category) REFERENCES dicts.staff_category (id_staff_category) ON DELETE CASCADE
);

--третий уровень категорий кадров
CREATE TABLE dicts.cat_3rd_lvl(
      id_cat_3rd_lvl        SERIAL UNIQUE PRIMARY KEY NOT NULL,
      name                  CHAR(50),
      id_cat_2nd_lvl        INT,
      FOREIGN KEY (id_cat_2nd_lvl) REFERENCES dicts.cat_2nd_lvl (id_cat_2nd_lvl) ON DELETE CASCADE
);
--кадры
CREATE TABLE dicts.staff(
    id_staff                SERIAL UNIQUE PRIMARY KEY NOT NULL,
    first_name              CHAR(50),
    last_name               CHAR(50),
    middle_name             CHAR(50),
    id_edu_orgs             INT,
    id_staff_category       INT,
    id_cat_2nd_lvl          INT,
    id_cat_3rd_lvl          INT,
    FOREIGN KEY (id_edu_orgs) REFERENCES dicts.edu_orgs (id_edu_orgs) ON DELETE CASCADE,
    FOREIGN KEY (id_staff_category) REFERENCES dicts.staff_category (id_staff_category) ON DELETE CASCADE,
    FOREIGN KEY (id_cat_2nd_lvl) REFERENCES dicts.cat_2nd_lvl (id_cat_2nd_lvl) ON DELETE CASCADE,
    FOREIGN KEY (id_cat_3rd_lvl) REFERENCES dicts.cat_3rd_lvl (id_cat_3rd_lvl) ON DELETE CASCADE
);

--связь органов управления с образовательными организациями
CREATE TABLE dicts.jrnl_authorities_of_edu_orgs(
    id_record               SERIAL UNIQUE PRIMARY KEY NOT NULL,
    id_edu_orgs             INT,
    id_authorities          INT,
    public_participation    BOOLEAN,

    FOREIGN KEY (id_edu_orgs) REFERENCES dicts.edu_orgs (id_edu_orgs) ON DELETE CASCADE,
    FOREIGN KEY (id_authorities) REFERENCES dicts.authorities (id_authorities) ON DELETE CASCADE
);



--НЕОБХОДИМО! тип образовательной программы
CREATE TABLE dicts.type_of_edu_program(
    id_type_of_edu_program  SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    CHAR(50)
);

--НЕОБХОДИМО! специальность или профессия
CREATE TABLE dicts.specialities(
    id_specialities         SERIAL UNIQUE PRIMARY KEY NOT NULL,
    code                    CHAR(20), --код специальности
    name                    CHAR(50), --название
    id_type_of_edu_program  INT,
    FOREIGN KEY (id_type_of_edu_program) REFERENCES dicts.type_of_edu_program (id_type_of_edu_program) ON DELETE CASCADE
);

--НЕОБХОДИМО! квалификация
CREATE TABLE dicts.qualification(
    id_qualification        SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    CHAR(50),
    id_specialities         INT,
    FOREIGN KEY (id_specialities) REFERENCES dicts.specialities (id_specialities) ON DELETE CASCADE
);

--НЕОБХОДИМО! Форма обучения
CREATE TABLE dicts.edu_form(
    id_edu_form             SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    CHAR(50)
);

--НЕОБХОДИМО! Уровень подготовки (базовый и углубленный)
CREATE TABLE dicts.edu_lvl(
    id_edu_lvl             SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                   CHAR(50)
);

--НЕОБХОДИМО! База приема
CREATE TABLE dicts.edu_base(
    id_edu_base            SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                   CHAR(50)
);

--НЕОБХОДИМО! СВОД по обр.программам
CREATE TABLE dicts.edu_programs(
    id_edu_programs         SERIAL UNIQUE PRIMARY KEY NOT NULL,
    id_type_of_edu_program  INT,
    id_specialities         INT,
    id_qualification        INT,
    id_edu_form             INT,
    id_edu_lvl              INT,
    id_edu_base             INT,
    id_edu_orgs             INT,
    length_in_months        INT,  --продолжительность программы в месяцах
    FOREIGN KEY (id_type_of_edu_program) REFERENCES dicts.type_of_edu_program (id_type_of_edu_program) ON DELETE CASCADE,
    FOREIGN KEY (id_specialities) REFERENCES dicts.specialities (id_specialities) ON DELETE CASCADE,
    FOREIGN KEY (id_qualification) REFERENCES dicts.qualification (id_qualification) ON DELETE CASCADE,
    FOREIGN KEY (id_edu_form) REFERENCES dicts.edu_form (id_edu_form) ON DELETE CASCADE,
    FOREIGN KEY (id_edu_lvl) REFERENCES dicts.edu_lvl (id_edu_lvl) ON DELETE CASCADE,
    FOREIGN KEY (id_edu_base) REFERENCES dicts.edu_base (id_edu_base) ON DELETE CASCADE,
    FOREIGN KEY (id_edu_orgs) REFERENCES dicts.edu_orgs (id_edu_orgs) ON DELETE CASCADE
);

--НЕОБХОДИМО! тип приема - БЮДЖЕТ или ДОГОВОР
CREATE TABLE dicts.type_of_admission(
    id_type_of_admission    SERIAL UNIQUE PRIMARY KEY NOT NULL,
    name                    CHAR(20)
);

--НЕОБХОДИМО! план приема абитуриентов
CREATE TABLE dicts.admission_plan (
    id_admission_plan       SERIAL UNIQUE PRIMARY KEY NOT NULL,
    id_edu_programs         INT,
    year                    DATE,
    admission_number        INT,     --предельная численность набора по программе
    targeted_admission      BOOLEAN, --целевой или нецелевой прием
    id_type_of_admission    INT,
    FOREIGN KEY (id_edu_programs) REFERENCES dicts.edu_programs (id_edu_programs) ON DELETE CASCADE,
    FOREIGN KEY (id_type_of_admission) REFERENCES dicts.type_of_admission (id_type_of_admission) ON DELETE CASCADE
);


--НЕОБХОДИМО! таблица абитуриента
CREATE TABLE dicts.applicants (
    id_applicants           SERIAL UNIQUE PRIMARY KEY NOT NULL,
    first_name              CHAR(50),
    last_name               CHAR(50),
    middle_name             CHAR(50),
    birthday                DATE,
    birth_place             CHAR(100),
    citizenship             CHAR(50),
    document                CHAR(100),
    seria                   CHAR(50),
    number                  CHAR(50),
    issued_by               CHAR(50), --кем выдан
    issued_when             CHAR(50), --когда выдан
    address                 CHAR(200),
    mob_phone               CHAR(50),
    home_phone              CHAR(50),
    e_mail                  CHAR(50),
    man_sex                 BOOLEAN,    --мужчина или нет тру-фолс
    privileged              BOOLEAN     --льготники
    --дальше не описываем - для статистики бесполезно
);


--НЕОБХОДИМО! форма заявления
CREATE TABLE dicts.application_forms(
    id_application_forms    SERIAL UNIQUE PRIMARY KEY NOT NULL,
    id_edu_orgs             INT,
    id_applicants           INT,
    app_date                DATE,

    FOREIGN KEY (id_edu_orgs) REFERENCES dicts.edu_orgs (id_edu_orgs) ON DELETE CASCADE,
    FOREIGN KEY (id_applicants) REFERENCES dicts.applicants (id_applicants) ON DELETE CASCADE
);

--НЕОБХОДИМО! Позиции заявления - по каким образовательным программа поданы заявления от абитуриента
CREATE TABLE dicts.app_edu_positions(
    id_app_edu_positions    SERIAL UNIQUE PRIMARY KEY NOT NULL,
    id_application_forms    INT,
    id_admission_plan       INT,

    FOREIGN KEY (id_application_forms) REFERENCES dicts.application_forms (id_application_forms) ON DELETE CASCADE,
    FOREIGN KEY (id_admission_plan) REFERENCES dicts.admission_plan (id_admission_plan) ON DELETE CASCADE
);

-- множество зачисленных студентов из числа абитуриентов
CREATE TABLE dicts.students(
    id_students             SERIAL UNIQUE PRIMARY KEY NOT NULL,
    id_app_edu_positions    INT,
    data                    DATE,
    FOREIGN KEY (id_app_edu_positions) REFERENCES dicts.app_edu_positions (id_app_edu_positions) ON DELETE CASCADE

);

