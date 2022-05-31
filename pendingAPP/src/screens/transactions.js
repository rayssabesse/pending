import { auto } from 'async';
import { StatusBar } from 'expo-status-bar';
import { hidden } from 'jest-haste-map/node_modules/chalk';
import { upperCase } from 'lodash';
import { StyleSheet, Text, View, Pressable, Image } from 'react-native';
import { Searchbar } from 'react-native-paper';
import React, { Component } from 'react';
import 'react-native-gesture-handler';
import { ScrollView } from 'react-native-gesture-handler';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { NavigationContainer } from '@react-navigation/native';

const bottomTab = createBottomTabNavigator();

import Home from './main';


export default class transactions extends React.Component {
    state = {
        firstQuery: '',
    };

    render() {
        const { firstQuery } = this.state;

        const Tab = createBottomTabNavigator();

        return (

            <View style={styles.main}>
                <View style={styles.mainHeader}>
                    <View style={styles.container_header}>

                        <View style={styles.container_header2}>
                            <View style={styles.containerAR}>
                                <Text style={styles.textName}>Nome completo</Text>
                            </View>

                            <View style={styles.containerData}>
                                <Text style={styles.textEmail}>usermail@pending.com</Text>
                                <Text style={styles.textCel}>+55 11 90000-0000</Text>
                            </View>

                            <Pressable style={styles.buttonSaldo}>
                                <Text style={styles.textButton}>SALDO: R$XXXX,XX</Text>
                            </Pressable>
                        </View>

                        <View style={styles.containerButton}>
                            <Pressable style={styles.buttonAdd}>
                                <Text style={styles.textButton}>adicionar cliente</Text>
                            </Pressable>

                            <Pressable style={styles.buttonRemove}>
                                <Text style={styles.textButton}>remover cliente</Text>
                            </Pressable>
                        </View>

                    </View>
                </View>

                <View style={styles.containerBusiness}>
                    <View>
                        <Text style={styles.textBusiness}>Transações</Text>
                    </View>
                </View>

                <View style={styles.containerTransaction}>
                    <View style={styles.textTransaction}>
                        <Text style={styles.textPag}>Pagamento</Text>
                        <Text style={styles.textClient}>Nome do Cliente</Text>
                    </View>
                </View>

                <View style={styles.containerTransaction}>
                    <View style={styles.textTransaction}>
                        <Text style={styles.textPag}>Pagamento</Text>
                        <Text style={styles.textClient}>Nome do Cliente</Text>
                    </View>
                </View>

            </View>
        );
    }
}

const styles = StyleSheet.create({
    main: {
        flex: 1,
        backgroundColor: '#F4F4F4',
    },

    textName: {
        fontSize: 23,
        fontWeight: '700',
        color: '#000',
        textTransform: 'uppercase',
    },

    mainHeader: {
        justifyContent: 'center',
        alignItems: 'center'
    },

    container_header: {
        width: '100%',
        height: 'auto',
        flexDirection: 'row',
    },

    containerAR: {
        marginLeft: 25,
        marginTop: 50,
    },

    textEmail: {
        fontSize: 13,
        color: '#999',
    },

    textCel: {
        fontSize: 13,
        color: '#999',
    },
    containerData: {
        marginLeft: 40,
    },

    containerBusiness: {
        marginTop: 30,
        alignItems: 'center',
        backgroundColor: '#363636',
    },

    textBusiness: {
        fontSize: 20,
        color: '#fff',
        textTransform: 'uppercase',
        fontWeight: '700',
    },

    buttonAdd: {
        width: 165,
        height: 40,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        backgroundColor: '#90C9E3',
        marginBottom: 40,
    },

    buttonRemove: {
        width: 165,
        height: 40,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        backgroundColor: '#222222',
    },

    buttonSaldo: {
        width: 165,
        height: 40,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        backgroundColor: '#999',
        marginTop: 15,
        marginLeft: 25,
    },

    textButton: {
        fontSize: 12,
        fontWeight: '700',
        color: 'white',
        textTransform: 'uppercase',
    },

    containerButton: {
        marginLeft: 20,
        marginTop: 50,
        height: 100,
    },

    containerTransaction: {
        marginLeft: 20,
        marginTop: 20,
    },

    textTransaction: {
        marginLeft: 30,
    },

    textPag: {
        marginBottom: 5,
    },
    textClient: {
        color: '#999',
    },


});
