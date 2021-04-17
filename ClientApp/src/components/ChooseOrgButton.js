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
        <a className="btn btn-outline-secondary btn-sm" onClick={toggle}>Выбрать организацию</a>
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