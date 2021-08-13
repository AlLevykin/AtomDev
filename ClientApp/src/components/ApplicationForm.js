import React, {useState} from 'react';
import { Dropdown, DropdownToggle, DropdownMenu, DropdownItem } from 'reactstrap';
import { analyticsData } from "../Data";

export const ApplicationForm = (props) => {

    const [dropdownOpen, setDropdownOpen] = useState(false);

    const toggle = () => setDropdownOpen(prevState => !prevState);
    const [lastClicked, setLastClicked] = useState(null);

    const filteredData = analyticsData.filter((applicant) =>
            { return applicant.Id === props.appId}
        ); 

    if(filteredData.length > 0)
    { 
        return (
            <div className="mt-5"> 
                <h3>Заявление</h3>
                <form className="row g-3">
                <div className="col-md-6">
                    <label for="appdate" className="form-label">Дата подачи заявления</label>
                    <input type="text" className="form-control" id="appdate" value={filteredData[0].CampaignDate} />
                </div>
                <div className="col-md-6">
                    <label for="appname" className="form-label">ФИО</label>
                    <input type="text" className="form-control" id="appname" value="Фамилия Имя Отчество" />
                </div>
                <div className="col-12">
                    <label for="inputSpeciality" className="form-label">Специальность</label>
                    <input type="text" className="form-control" id="inputSpeciality" value={filteredData[0].Speciality} />
                </div>
                <div className="col-12">
                    <label for="inputEduProgram" className="form-label">Программа обучения</label>
                    <input type="text" className="form-control" id="inputEduProgram" value={filteredData[0].EduProgramType}  />
                </div>                
                <div className="col-12">
                    <label for="inputEduOrg" className="form-label">Учебное заведение</label>
                    <input type="text" className="form-control" id="inputEduOrg" value={filteredData[0].EduProgram}  />
                </div>
                <div className="col-md-6">
                    <label for="inputApplicationType" className="form-label">Тип</label>
                    <input type="text" className="form-control" id="inputApplicationType" value={filteredData[0].ApplicationType} />
                </div>
                <div className="col-md-6">
                    <label for="inputEduProgramForm" className="form-label">Форма обучения</label>
                    <input type="text" className="form-control" id="inputEduProgramForm" value={filteredData[0].EduProgramForm} />
                </div>
                <div className="col-md-6"> 
                <div className="d-grid gap-2">
                <Dropdown className="btn btn-secondary" isOpen={dropdownOpen} toggle={toggle}>
                    <DropdownToggle caret>
                    Сохранить
                    </DropdownToggle>
                    <DropdownMenu container="body">
                    <DropdownItem onClick={() => setLastClicked(1)}>Word</DropdownItem>
                    <DropdownItem onClick={() => setLastClicked(2)}>Excel</DropdownItem>
                    <DropdownItem onClick={() => setLastClicked(3)}>Pdf</DropdownItem>
                    </DropdownMenu>
                </Dropdown>
                </div></div>  <div className="col-md-6"><div className="d-grid gap-2">
                <button type="button" className="btn btn-secondary">Печать</button></div></div>    
                </form>
            </div>
        );
    } else {
        return (
            <div className="mt-5">        
            </div>
        );
    }
}