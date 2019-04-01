/*
This query loads the database schema into mySQL DMBS
*/

CREATE DATABASE zoo;
USE zoo;

/********************* BEGIN ENUMERATED DATA TYPES *********************/
/*
This table represents an enumerated data type and contains
all species of animal within a zoo
REFERENCED BY: ANIMAL(species)
*/
CREATE TABLE ENUM_SPECIES (
	species_id				INT UNSIGNED			NOT NULL,
    species_name			VARCHAR(15)				NOT NULL,
    CONSTRAINT ENUM_SPECIES_PK
		PRIMARY KEY (species_id)
);

/*
This table represents an enumerated data type and contains
all medications administered to animals within a zoo
REFERENCED BY: PRESCRIPTION(medication)
*/
CREATE TABLE ENUM_MEDICATION (
	med_id					INT UNSIGNED			NOT NULL,
    med_name				VARCHAR(30)				NOT NULL,
    CONSTRAINT ENUM_MEDICATION_PK
		PRIMARY KEY (med_id)
);

/*
This table represents an enumerated data type and contains
all units of measurement for prescriptions
REFERENCED BY: PRESCRIPTION(dosage_unit), DIET(feeding_unit)
*/
CREATE TABLE ENUM_UNIT_MEASURE (
	unit_id					VARCHAR(2)				NOT NULL,
    unit_name				VARCHAR(10)				NOT NULL,
    CONSTRAINT ENUM_UNIT_MEASURE_PK
		PRIMARY KEY (unit_id)
);

/*
This table represents an enumerated data type and contains
all ecosystem types present in a zoo
REFERENCED BY: EXHIBIT(ecosystem)
*/
CREATE TABLE ENUM_ECOSYSTEM (
	ecosystem_id			INT UNSIGNED			NOT NULL,
    ecosystem_name			VARCHAR(15)				NOT NULL,
    CONSTRAINT ECOSYSTEM_PK
		PRIMARY KEY (ecosystem_id)
);

/*
This table represents an enumerated data type and contains
all sub-sections that make up a zoo/park
(i.e. African Forest, Wortham World of Primates)
REFERENCED BY: EXHIBIT(section), ATTRACTION(section)
*/
CREATE TABLE ENUM_SECTION (
	section_id				INT UNSIGNED			NOT NULL,
    section_name			VARCHAR(30)				NOT NULL,
    CONSTRAINT SECTION_PK
		PRIMARY KEY (section_id)
);

/*
This table represents an enumerated data type and contatins
all US states and territories in which a zoo may be
located
REFERENCED BY: CONTACT(state)
*/
CREATE TABLE ENUM_STATE (
	state_id				CHAR(2)					NOT NULL,
    state_name				VARCHAR(12)				NOT NULL,
    CONSTRAINT STATE_PK
		PRIMARY KEY (state_id)
);

/*
This table represents an enumerated data type and contains
all departments that make up a zoo
REFERENCED BY: EMPLOYEE_POSITION(position_id)
*/
CREATE TABLE ENUM_DEPARTMENT (
	dept_id					INT UNSIGNED			NOT NULL,
    dept_name				VARCHAR(30)				NOT NULL,
    CONSTRAINT DEPT_PK
		PRIMARY KEY (dept_id)
);

/*
This table represents an enumerated data type and contains
all pay types offered to employees of a zoo
(i.e. wages, salary)
REFERENCED BY: EMPLOYEE_PAY(pay_type)
*/
CREATE TABLE ENUM_PAY_TYPE (
	pay_type_id				INT UNSIGNED			NOT NULL,
    pay_type_name			VARCHAR(6)				NOT NULL,
    CONSTRAINT PAY_TYPE_PK
		PRIMARY KEY (pay_type_id)
);

/*
This table represents an enumerated data type and contains
all types of memberships available to zoo patrons
(i.e. annual, seasonal)
REFERENCED BY: MEMBERSHIP(member_type)
*/
CREATE TABLE ENUM_MEMBERSHIP_TYPE (
	member_type_id			INT UNSIGNED			NOT NULL,
    member_type_name		VARCHAR(15)				NOT NULL,
    CONSTRAINT MEMBER_TYPE_PK
		PRIMARY KEY (member_type_id)
);

/*
This table represents an enumerated data type and contains
all statuses related to zoo memberships
(i.e. active, inactive)
REFERENCED BY: MEMBERSHIP(member_status)
*/
CREATE TABLE ENUM_MEMBERSHIP_STATUS (
	member_status_id		INT UNSIGNED			NOT NULL,
    member_status_name		VARCHAR(15)				NOT NULL,
    CONSTRAINT MEMBER_STATUS_PK
		PRIMARY KEY (member_status_id)
);

/*
This table represents an enumerated data type and contains
all statuses related to the operation of attractions
(i.e. working, needs repair)
REFERENCED BY: ATTRACTION(attr_status)
*/
CREATE TABLE ENUM_ATTRACTION_STATUS (
	status_id				INT UNSIGNED			NOT NULL,
    status_name				VARCHAR(15)				NOT NULL,
    CONSTRAINT ATTR_STATUS_PK
		PRIMARY KEY (status_id)
);
/********************* END ENUMERATED DATA TYPES *********************/

/*
This table contains all possible animal health conditions as
well as information about the conditions
REFERENCED BY: HEALTH_PROFILE(health_condition)
*/
CREATE TABLE HEALTH_CONDITION (
	condition_id			INT UNSIGNED			NOT NULL,
    condition_name			VARCHAR(45)				NOT NULL,
    condition_info			VARCHAR(140),
    CONSTRAINT HEALTH_CONDITION_PK
		PRIMARY KEY (condition_id)
);

/*
This table contains information about animal prescriptions
REFERENCED BY: TREATMENT_PLAN(prescription)
*/
CREATE TABLE PRESCRIPTION (
	prescription_id			INT UNSIGNED			NOT NULL,
    medication				INT UNSIGNED			NOT NULL,
    dosage_size				DECIMAL(6, 3)			NOT NULL,
    dosage_unit				VARCHAR(2)				NOT NULL,
    doses_per_week			INT UNSIGNED			NOT NULL,
    CONSTRAINT PRESCRIPTION_PK
		PRIMARY KEY (prescription_id),
    CONSTRAINT PRESCRIPTION_MED_FK
		FOREIGN KEY (medication) REFERENCES ENUM_MEDICATION(med_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
    CONSTRAINT PRESCRIPTION_UNIT_FK
		FOREIGN KEY (dosage_unit) REFERENCES ENUM_UNIT_MEASURE(unit_id),
	CONSTRAINT DOSAGE_SIZE_MIN
		CHECK (dosage_size > 0)
);

/*
This table contains information about animal diets
REFERENCED BY: TREATMENT_PLAN(diet)
*/
CREATE TABLE DIET (
	diet_id					INT UNSIGNED			NOT NULL,
    diet_info				VARCHAR(140),
    feeding_size			DECIMAL(6, 3)			NOT NULL,
    feeding_unit			VARCHAR(2)				NOT NULL,
    feedings_per_day		INT UNSIGNED			NOT NULL,
    CONSTRAINT DIET_PK
		PRIMARY KEY (diet_id),
	CONSTRAINT DIET_UNIT_FK
		FOREIGN KEY (feeding_unit) REFERENCES ENUM_UNIT_MEASURE(unit_id),
	CONSTRAINT FEEDING_SIZE_MIN
		CHECK (feeding_size > 0)
);

/*
This table contains information about plans for treating
animals with certain health conditions
REFERENCED BY: HEALTH_PROFILE(treatment_plan)
*/
CREATE TABLE TREATMENT_PLAN (
	treatment_id			INT UNSIGNED			NOT NULL,
    treatment_info			VARCHAR(140),
    prescription			INT UNSIGNED,
    diet					INT UNSIGNED,
    CONSTRAINT TREATMENT_PK
		PRIMARY KEY (treatment_id),
	CONSTRAINT TREATMENT_PRESCRIPTION_FK
		FOREIGN KEY (prescription) REFERENCES PRESCRIPTION(prescription_id)
			ON DELETE SET NULL		ON UPDATE CASCADE,
	CONSTRAINT TREATMENT_DIET_FK
		FOREIGN KEY (diet) REFERENCES DIET(diet_id)
			ON DELETE SET NULL		ON UPDATE CASCADE
);

/*
This table contains information about the overall health of
each animal within a zoo
REFERENCED BY: ANIMAL(health_profile)
*/
CREATE TABLE HEALTH_PROFILE (
	profile_id				INT UNSIGNED			NOT NULL,
    sex						ENUM('M','F')			NOT NULL,
    DOB						DATE					NOT NULL,
    weight					DECIMAL(6, 3)			NOT NULL,
    weight_unit				VARCHAR(2)				NOT NULL,
    height					DECIMAL(6, 3)			NOT NULL,
    height_unit				VARCHAR(2)				NOT NULL,
    health_condition		INT UNSIGNED			NOT NULL,
    treatment_plan			INT UNSIGNED,
    CONSTRAINT PROFILE_PK
		PRIMARY KEY (profile_id),
	CONSTRAINT PROFILE_WUNIT_FK
		FOREIGN KEY (weight_unit) REFERENCES ENUM_UNIT_MEASURE(unit_id),
	CONSTRAINT PROFILE_HUNIT_FK
		FOREIGN KEY (height_unit) REFERENCES ENUM_UNIT_MEASURE(unit_id),
	CONSTRAINT PROFILE_CONDITION_FK
		FOREIGN KEY (health_condition) REFERENCES HEALTH_CONDITION(condition_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
	CONSTRAINT PROFILE_TREATMENT_FK
		FOREIGN KEY (treatment_plan) REFERENCES TREATMENT_PLAN(treatment_id)
			ON DELETE SET NULL		ON UPDATE CASCADE,
	CONSTRAINT WEIGHT_MIN
		CHECK (weight > 0),
	CONSTRAINT HEIGHT_MIN
		CHECK (height > 0)
);

/*
This table contains information about each animal exhibit
within a zoo
REFERENCED BY: ANIMAL(exhibit)
*/
CREATE TABLE EXHIBIT (
	exhibit_id				INT UNSIGNED			NOT NULL,
    exhibit_name			VARCHAR(30)				NOT NULL,
    size					DECIMAL(6, 3)			NOT NULL,
    size_unit				VARCHAR(2)				NOT NULL,
    ecosystem				INT UNSIGNED			NOT NULL,
    section					INT UNSIGNED			NOT NULL,
    CONSTRAINT EXHIBIT_PK
		PRIMARY KEY (exhibit_id),
	CONSTRAINT EXHIBIT_UNIT_FK
		FOREIGN KEY (size_unit) REFERENCES ENUM_UNIT_MEASURE(unit_id),
	CONSTRAINT EXHIBIT_ECOSYSTEM_FK
		FOREIGN KEY (ecosystem) REFERENCES ENUM_ECOSYSTEM(ecosystem_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
	CONSTRAINT EXHIBIT_SECTION_FK
		FOREIGN KEY (section) REFERENCES ENUM_SECTION(section_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
	CONSTRAINT SIZE_MIN
		CHECK (size > 0)
);

/*
This table contains information about every animal living
within a zoo
*/
CREATE TABLE ANIMAL (
	animal_id				INT UNSIGNED			NOT NULL,
    animal_name				VARCHAR(15)				NOT NULL,
    species					INT UNSIGNED			NOT NULL,
    health_profile			INT UNSIGNED			NOT NULL,
    diet					INT UNSIGNED			NOT NULL,
    exhibit					INT UNSIGNED			NOT NULL,
    CONSTRAINT ANIMAL_PK
		PRIMARY KEY (animal_id),
	CONSTRAINT ANIMAL_SPECIES_FK
		FOREIGN KEY (species) REFERENCES ENUM_SPECIES(species_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
	CONSTRAINT ANIMAL_PROFILE_FK
		FOREIGN KEY (health_profile) REFERENCES HEALTH_PROFILE(profile_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
	CONSTRAINT ANIMAL_DIET_FK
		FOREIGN KEY (diet) REFERENCES DIET(diet_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
	CONSTRAINT ANIMAL_EXHIBIT_FK
		FOREIGN KEY (exhibit) REFERENCES EXHIBIT(exhibit_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE
);

/*
This table contains the contact information of employees and
members of a zoo
REFERENCED BY:	EMPLOYEE(contact_info),
				MEMBERSHIP(primary_contact),
                MEMBERSHIP(secondary_contact)
*/
CREATE TABLE CONTACT (
	contact_id				INT UNSIGNED			NOT NULL,
    phone_no				VARCHAR(11),
    email_addr				VARCHAR(30),
    addr_line1				VARCHAR(30),
    addr_line2				VARCHAR(30),
    city					VARCHAR(15),
    state					CHAR(2),
    zip_code				VARCHAR(9),
    CONSTRAINT CONTACT_PK
		PRIMARY KEY (contact_id),
	CONSTRAINT CONTACT_STATE_FK
		FOREIGN KEY (state) REFERENCES ENUM_STATE(state_id)
);

/*
This table contains information about job positions that
exist within a zoo
REFERENCED BY: EMPLOYEE(job_position)
*/
CREATE TABLE JOB_POSITION (
	position_id				INT UNSIGNED			NOT NULL,
    job_title				VARCHAR(30)				NOT NULL,
    job_description			VARCHAR(140)			NOT NULL,
    department				INT UNSIGNED			NOT NULL,
    CONSTRAINT POSITION_PK
		PRIMARY KEY (position_id),
	CONSTRAINT POSITION_DEPT_FK
		FOREIGN KEY (department) REFERENCES ENUM_DEPARTMENT(dept_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE
);

/*
This table contains information related to employee
compensation
REFERENCED BY: EMPLOYEE(emply_pay)
*/
CREATE TABLE EMPLOYEE_PAY (
	pay_id					INT UNSIGNED			NOT NULL,
    pay_type				INT UNSIGNED			NOT NULL,
    hourly_wage				DECIMAL(4, 2),
    annual_salary			INT UNSIGNED,
    effective_date			DATE					NOT NULL,
    CONSTRAINT PAY_PK
		PRIMARY KEY (pay_id),
    CONSTRAINT PAY_TYPE_FK
		FOREIGN KEY (pay_type) REFERENCES ENUM_PAY_TYPE(pay_type_id),
	CONSTRAINT HOURLY_WAGE_MIN
		CHECK (hourly_wage > 0)
);

/*
This table contains information about every member of staff
employed by a zoo
*/
CREATE TABLE EMPLOYEE (
	empl_id					INT UNSIGNED			NOT NULL,
    first_name				VARCHAR(15)				NOT NULL,
    middle_name				VARCHAR(15),
    last_name				VARCHAR(15)				NOT NULL,
    contact_info			INT UNSIGNED			NOT NULL,
    job_position			INT UNSIGNED			NOT NULL,
    empl_pay				INT UNSIGNED			NOT NULL,
    CONSTRAINT EMPL_PK
		PRIMARY KEY (empl_id),
    CONSTRAINT EMPL_CONTACT_FK
		FOREIGN KEY (contact_info) REFERENCES CONTACT(contact_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
    CONSTRAINT EMPL_POSITION_FK
		FOREIGN KEY (job_position) REFERENCES JOB_POSITION(position_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
    CONSTRAINT EMPL_PAY_FK
		FOREIGN KEY (empl_pay) REFERENCES EMPLOYEE_PAY(pay_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE
);

/*
This table contains information about individual employee
shifts
*/
CREATE TABLE SHIFT (
	shift_id				INT UNSIGNED			NOT NULL,
    employee				INT UNSIGNED			NOT NULL,
    clock_in				DATETIME				NOT NULL,
    clock_out				DATETIME,
    CONSTRAINT SHIFT_PK
		PRIMARY KEY (shift_id),
    CONSTRAINT SHIFT_EMPL_FK
		FOREIGN KEY (employee) REFERENCES EMPLOYEE(empl_id)
);

/*
This table contains information about payroll pay periods
*/
CREATE TABLE PAY_PERIOD (
	period_id				INT UNSIGNED			NOT NULL,
    start_date				DATE					NOT NULL,
    end_date				DATE					NOT NULL,
    CONSTRAINT PERIOD_PK
		PRIMARY KEY (period_id)
);

/*
This table contains information about memberships available
to zoo patrons
*/
CREATE TABLE MEMBERSHIP (
	member_id				INT UNSIGNED			NOT NULL,
    member_type				INT UNSIGNED			NOT NULL,
    primary_contact			INT UNSIGNED			NOT NULL,
    secondary_contact		INT UNSIGNED,
    registration_date		DATE					NOT NULL,
    member_status			INT UNSIGNED			NOT NULL,
    CONSTRAINT MEMBER_PK
		PRIMARY KEY (member_id),
    CONSTRAINT MEMBER_TYPE_FK
		FOREIGN KEY (member_type) REFERENCES ENUM_MEMBERSHIP_TYPE(member_type_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
    CONSTRAINT MEMBER_PCONTACT_FK
		FOREIGN KEY (primary_contact) REFERENCES CONTACT(contact_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
    CONSTRAINT MEMBER_SCONTACT_FK
		FOREIGN KEY (secondary_contact) REFERENCES CONTACT(contact_id)
			ON DELETE SET NULL		ON UPDATE CASCADE,
    CONSTRAINT MEMBER_STATUS_FK
		FOREIGN KEY (member_status) REFERENCES ENUM_MEMBERSHIP_STATUS(member_status_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE
);

/*
This table contains information about attractions within the
zoo
*/
CREATE TABLE ATTRACTION (
	attr_id					INT UNSIGNED			NOT NULL,
    attr_name				VARCHAR(15)				NOT NULL,
    attr_status				INT UNSIGNED			NOT NULL,
    section					INT UNSIGNED			NOT NULL,
    CONSTRAINT ATTR_PK
		PRIMARY KEY (attr_id),
    CONSTRAINT ATTR_STATUS_FK
		FOREIGN KEY (attr_status) REFERENCES ENUM_ATTRACTION_STATUS(status_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE,
    CONSTRAINT ATTR_SECTION_FK
		FOREIGN KEY (section) REFERENCES ENUM_SECTION(section_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE
);

/*
This table contains information related to all scheduled
repairs within a zoo
*/
CREATE TABLE SCHEDULED_REPAIR (
	repair_id				INT UNSIGNED			NOT NULL,
    repair_info				VARCHAR(140),
    date_time				DATETIME				NOT NULL,
    repairer				INT UNSIGNED			NOT NULL,
    CONSTRAINT REPAIR_PK
		PRIMARY KEY (repair_id),
    CONSTRAINT REPAIR_REPAIRER_FK
		FOREIGN KEY (repairer) REFERENCES EMPLOYEE(empl_id)
			ON DELETE RESTRICT		ON UPDATE CASCADE
);

/*
This table contains login information about users of the web
application that interacts with the database
*/
CREATE TABLE APP_USER (
	user_id					INT UNSIGNED			NOT NULL,
    username				VARCHAR(15)				NOT NULL,
    user_password			VARCHAR(30)				NOT NULL,
    CONSTRAINT USER_PK
		PRIMARY KEY (user_id),
	CONSTRAINT USER_ID_FK
		FOREIGN KEY (user_id) REFERENCES EMPLOYEE(empl_id)
			ON DELETE CASCADE		ON UPDATE CASCADE
);
