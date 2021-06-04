import { Container, Grid, Typography } from '@material-ui/core';
import React, { useEffect, useState } from 'react';
import { getUsers } from '../../actions/UsersAction';
import DialogComponent from '../../Components/Dialog/DialogComponent';
import Table from '../../Components/Table/Table';
import styles from '../../Theme/Styles';

const TableUsers = () => {
    const [user, setUser] = useState({
        id:'',
        name:'',
        age:'',
        birthDay:'',
    });

    const [dialog, setDialog] = useState(false);

    const [users, setUsers]  = useState([]);

    const handleChange =(e) => {
        const { name, value } = e.target;
        setUser(prev => ({
            ...prev,
            [name] : value
        }))
    }

    const saveData = () => {
        console.log("user", user);        
    }

    const openDialog = () => {
        setDialog(true);
    }
    const closeDialog = () => {
        setDialog(false);
    }
    useEffect(()=> {
        console.log(process.env.REACT_APP_API_URL)
        const listUsers = async () => {
            const data = await getUsers();
            setUsers(data.data);
        }
        listUsers();
    },[])

    const classes = styles();
    return (
        <Container >
                <Grid container className={classes.header}>
                    <Grid item xs={12} >
                        <Typography variant="h5" color="secondary" >Asesoftware</Typography>
                    </Grid>
                </Grid>
                <Grid container className={classes.body}>
                    <Grid item xs={12} >
                        <Table openDialog={openDialog} users={users} setUser={setUser}/>
                    </Grid>
                </Grid>
                <DialogComponent dialog={dialog} closeDialog={closeDialog}  user={user}/>
            </Container>
    );
};

export default TableUsers;