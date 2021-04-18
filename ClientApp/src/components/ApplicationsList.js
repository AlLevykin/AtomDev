import React, { useState } from 'react';
import { Table } from 'reactstrap';
import { Row, Col, Button } from 'reactstrap';
import { ApplicationForm } from './ApplicationForm';
import { analyticsData } from "../Data";

export const ApplicationsList = (props) => {

    const [curApp, setCurApp] = useState({Id: -1});

    const { year } = props;

    const filteredData = analyticsData.filter((applicant) =>
            { return applicant.CampaignDate.indexOf(year) >= 0 }
        );

    const items = filteredData.map(applicant =>                 
                <tr key={applicant.Id}>
                <th scope="row">{applicant.CampaignDate}</th>
                <td>Фамилия И.О.</td>
                <td>{applicant.Speciality}</td>
                <td>{applicant.EduProgram}</td>
                <td><Button color="secondary" onClick={() => setCurApp(applicant)}>
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-file-earmark-text me-2 ms-2" viewBox="0 0 16 16">
                    <path d="M5.5 7a.5.5 0 0 0 0 1h5a.5.5 0 0 0 0-1h-5zM5 9.5a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5zm0 2a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5z"/>
                    <path d="M9.5 0H4a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2V4.5L9.5 0zm0 1v2A1.5 1.5 0 0 0 11 4.5h2V14a1 1 0 0 1-1 1H4a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h5.5z"/>
                    </svg>
                    </Button></td>                
                </tr>
    );

    return (
        <div className="mt-3">
        <Row>
        <Col>
        <Table hover>
            <thead>
                <tr>
                <th>Дата подачи заявления</th>
                <th>ФИО</th>
                <th>Специальность</th>
                <th>Учебное заведение</th>
                <th>Просмотр</th>                
                </tr>
            </thead>
            <tbody>
                {items}
            </tbody>
        </Table>
        </Col>
        <Col>
            <ApplicationForm appId={curApp.Id}></ApplicationForm>
        </Col>
        </Row>
        </div>
    );
}