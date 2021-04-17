import React, { useState, useContext } from 'react';
import { useHistory } from "react-router-dom";
import { Button, Modal, ModalHeader, ModalBody, ModalFooter, ListGroup, ListGroupItem } from 'reactstrap';
import EduOrgContext from './EduOrgContext';
import { organisations } from "../unpoTomsk";

export const ChooseOrgButton = () => {

    const history = useHistory();
    
    const [modal, setModal] = useState(false);
  
    const toggle = () => setModal(!modal);

    const context = useContext(EduOrgContext);

    const choose = (orgName) => {
        context.toggleOrg(orgName);
        setModal(!modal);
        history.push("/"); 
    }
  
    return (
      <div>
        <a className="btn btn-outline-secondary btn-sm" onClick={toggle}>
          <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-house-fill me-2 ms-2" viewBox="0 0 16 16">
            <path d="M1.5 15a.5.5 0 0 0 0 1h13a.5.5 0 0 0 0-1H13V2.5A1.5 1.5 0 0 0 11.5 1H11V.5a.5.5 0 0 0-.57-.495l-7 1A.5.5 0 0 0 3 1.5V15H1.5zM11 2h.5a.5.5 0 0 1 .5.5V15h-1V2zm-2.5 8c-.276 0-.5-.448-.5-1s.224-1 .5-1 .5.448.5 1-.224 1-.5 1z"/>
          </svg>
          Вход
        </a>
        <Modal isOpen={modal} toggle={toggle} scrollable={true}>
          <ModalHeader toggle={toggle}>Выбрать организацию</ModalHeader>
          <ModalBody>
            <ListGroup>
                {
                    organisations.map((org) =>
                    <ListGroupItem key={org.name} tag="button" action onClick={()=>{choose(org.name)}}>{org.name}</ListGroupItem>
                    )
                }              
            </ListGroup>
          </ModalBody>
          <ModalFooter>
            <Button color="secondary" onClick={toggle}>Отмена</Button>
          </ModalFooter>
        </Modal>
      </div>
    );
  }